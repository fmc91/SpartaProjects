using System;
using System.Collections.Generic;
using System.Linq;
using BlogitEntityModel;

namespace BlogitCrud
{
    public enum LoginValidationResult { UsernameNotFound, IncorrectPassword, Success }

    public class CrudManager
    {
        public List<BlogPost> GetRecentPosts(int count)
        {
            using (BlogitContext db = new BlogitContext())
            {
                List<BlogPost> recentPosts =
                (
                    from p in db.Post
                    join b in db.Blog on p.BlogId equals b.BlogId
                    join u in db.User on b.UserId equals u.UserId
                    orderby p.Date descending
                    select new BlogPost
                    {
                        PostId = p.PostId,
                        BlogName = b.Name,
                        Username = u.Username,
                        Author = u.Name,
                        Date = p.Date,
                        Title = p.Title,
                        Content = p.Content
                    }
                )
                .Take(count).ToList();

                return recentPosts;
            }
        }

        public List<BlogInfo> GetRecentlyActiveBlogInfo(int count)
        {
            using (BlogitContext db = new BlogitContext())
            {
                List<BlogInfo> blogInfo =
                (
                    from b in db.Blog
                    join u in db.User on b.UserId equals u.UserId
                    join p in db.Post on b.BlogId equals p.BlogId
                    group p.Date by new { b.BlogId, b.Name, b.Category, b.About, u.Username, Author = u.Name, u.JoinDate } into grp
                    orderby grp.Max() descending
                    select new BlogInfo
                    {
                        BlogId = grp.Key.BlogId,
                        Username = grp.Key.Username,
                        Name = grp.Key.Name,
                        Author = grp.Key.Author,
                        Category = grp.Key.Category,
                        About = grp.Key.About,
                        ActiveSince = grp.Key.JoinDate,
                        LatestPost = grp.Max(),
                        PostCount = grp.Count()
                    }
                )
                .Take(count).ToList();

                return blogInfo;
            }
        }

        public BlogInfo GetBlogInfoById(int blogId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                BlogInfo blogInfo =
                (
                    from b in db.Blog
                    join u in db.User on b.UserId equals u.UserId
                    where b.BlogId == blogId
                    select new BlogInfo
                    {
                        BlogId = b.BlogId,
                        Username = u.Username,
                        Name = b.Name,
                        Author = u.Name,
                        Category = b.Category,
                        About = b.About,
                        ActiveSince = u.JoinDate
                    }
                )
                .Single();

                var query =
                    from b in db.Blog
                    join p in db.Post on b.BlogId equals p.BlogId
                    where b.BlogId == blogId
                    group p.Date by b.BlogId into grp
                    select new { LatestPost = grp.Max(), PostCount = grp.Count() };

                if (query.Any())
                {
                    var queryResult = query.Single();

                    blogInfo.LatestPost = queryResult.LatestPost;
                    blogInfo.PostCount = queryResult.PostCount;
                }
                else
                {
                    blogInfo.PostCount = 0;
                }

                return blogInfo;
            }
        }

        public BlogInfo GetBlogInfoByUserId(int userId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                BlogInfo blogInfo =
                (
                    from u in db.User
                    join b in db.Blog on u.UserId equals b.UserId
                    where u.UserId == userId
                    select new BlogInfo
                    {
                        BlogId = b.BlogId,
                        Username = u.Username,
                        Name = b.Name,
                        Author = u.Name,
                        Category = b.Category,
                        About = b.About,
                        ActiveSince = u.JoinDate
                    }
                )
                .Single();

                var query =
                    from b in db.Blog
                    join p in db.Post on b.BlogId equals p.BlogId
                    where b.BlogId == blogInfo.BlogId
                    group p.Date by b.BlogId into grp
                    select new { LatestPost = grp.Max(), PostCount = grp.Count() };

                if (query.Any())
                {
                    var queryResult = query.Single();

                    blogInfo.LatestPost = queryResult.LatestPost;
                    blogInfo.PostCount = queryResult.PostCount;
                }
                else
                {
                    blogInfo.PostCount = 0;
                }

                return blogInfo;
            }
        }

        public List<BlogPost> GetPostsByUserId(int userId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                List<BlogPost> postsByUser =
                (
                    from p in db.Post
                    join b in db.Blog on p.BlogId equals b.BlogId
                    join u in db.User on b.UserId equals u.UserId
                    where u.UserId == userId
                    orderby p.Date descending
                    select new BlogPost
                    {
                        PostId = p.PostId,
                        Username = u.Username,
                        Author = u.Name,
                        BlogName = b.Name,
                        Date = p.Date,
                        Title = p.Title,
                        Content = p.Content
                    }
                )
                .ToList();

                return postsByUser;
            }
        }

        public List<BlogPost> GetPostsByBlogId(int blogId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                List<BlogPost> postsByBlog =
                (
                    from p in db.Post
                    join b in db.Blog on p.BlogId equals b.BlogId
                    join u in db.User on b.UserId equals u.UserId
                    where b.BlogId == blogId
                    orderby p.Date descending
                    select new BlogPost
                    {
                        PostId = p.PostId,
                        Username = u.Username,
                        Author = u.Name,
                        BlogName = b.Name,
                        Date = p.Date,
                        Title = p.Title,
                        Content = p.Content
                    }
                )
                .ToList();

                return postsByBlog;
            }
        }

        public BlogPost GetPostById(int postId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                BlogPost blogPost =
                (
                    from p in db.Post
                    join b in db.Blog on p.BlogId equals b.BlogId
                    join u in db.User on b.UserId equals u.UserId
                    where p.PostId == postId
                    select new BlogPost
                    {
                        PostId = p.PostId,
                        Username = u.Username,
                        Author = u.Name,
                        BlogName = b.Name,
                        Date = p.Date,
                        Title = p.Title,
                        Content = p.Content
                    }
                )
                .Single();

                return blogPost;
            }
        }

        public void CreatePost(int userId, string title, string content)
        {
            using (BlogitContext db = new BlogitContext())
            {
                int blogId =
                (
                    from u in db.User
                    join b in db.Blog on u.UserId equals b.UserId
                    where u.UserId == userId
                    select b.BlogId
                )
                .Single();

                Post newPost = new Post
                {
                    BlogId = blogId,
                    Date = DateTime.Today,
                    Title = title,
                    Content = content
                };

                db.Post.Add(newPost);

                db.SaveChanges();
            }
        }

        public void ModifyPost(int postId, string title, string content)
        {
            using (BlogitContext db = new BlogitContext())
            {
                Post selectedPost =
                (
                    from p in db.Post
                    where p.PostId == postId
                    select p
                )
                .Single();

                selectedPost.Title = title;
                selectedPost.Content = content;

                db.SaveChanges();
            }
        }

        public void DeletePost(int postId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                Post selectedPost =
                (
                    from p in db.Post
                    where p.PostId == postId
                    select p
                )
                .Single();

                db.Post.Remove(selectedPost);

                db.SaveChanges();
            }
        }

        public bool UsernameInUse(string username)
        {
            using (BlogitContext db = new BlogitContext())
            {
                var userQuery =
                    from u in db.User
                    where u.Username == username
                    select u;

                return userQuery.Any();
            }
        }

        public int GetUserId(string username)
        {
            using (BlogitContext db = new BlogitContext())
            {
                int userId =
                (
                    from u in db.User
                    where u.Username == username
                    select u.UserId
                )
                .Single();

                return userId;
            }
        }

        public string GetUserEmailById(int userId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                string emailAddress =
                (
                    from u in db.User
                    where u.UserId == userId
                    select u.EmailAddress
                )
                .Single();

                return emailAddress;
            }
        }

        public void CreateUser(string username, string password, string emailAddress)
        {
            using (BlogitContext db = new BlogitContext())
            {
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    EmailAddress = emailAddress,
                    JoinDate = DateTime.Today
                };

                db.User.Add(newUser);

                db.SaveChanges();
            }
        }

        public void SetUserActualName(int userId, string name)
        {
            using (BlogitContext db = new BlogitContext())
            {
                User selectedUser =
                (
                    from u in db.User
                    where u.UserId == userId
                    select u
                )
                .Single();

                selectedUser.Name = name;

                db.SaveChanges();
            }
        }

        public void ModifyUserDetails(int userId, string emailAddress, string name)
        {
            using (BlogitContext db = new BlogitContext())
            {
                User selectedUser =
                (
                    from u in db.User
                    where u.UserId == userId
                    select u
                )
                .Single();

                selectedUser.EmailAddress = emailAddress;
                selectedUser.Name = name;

                db.SaveChanges();
            }
        }

        public bool UserHasBlog(int userId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                var blogQuery =
                    from u in db.User
                    join b in db.Blog on u.UserId equals b.UserId
                    where u.UserId == userId
                    select b;

                return blogQuery.Any();
            }
        }

        public void CreateBlog(int userId, string name, string category, string about)
        {
            using (BlogitContext db = new BlogitContext())
            {
                Blog newBlog = new Blog
                {
                    Name = name,
                    Category = category,
                    About = about,
                    UserId = userId
                };

                db.Blog.Add(newBlog);

                db.SaveChanges();
            }
        }

        public void ModifyBlogDetails(int userId, string name, string category, string about)
        {
            using (BlogitContext db = new BlogitContext())
            {
                Blog selectedBlog =
                (
                    from u in db.User
                    join b in db.Blog on u.UserId equals b.UserId
                    where u.UserId == userId
                    select b
                )
                .Single();

                selectedBlog.Name = name;
                selectedBlog.Category = category;
                selectedBlog.About = about;

                db.SaveChanges();
            }
        }

        public string GetUsername(int userId)
        {
            using (BlogitContext db = new BlogitContext())
            {
                string username =
                (
                    from u in db.User
                    where u.UserId == userId
                    select u.Username
                )
                .Single();

                return username;
            }
        }

        public LoginValidationResult ValidateLogin(string username, string password, out int userId)
        {
            userId = -1;

            using (BlogitContext db = new BlogitContext())
            {
                var userQuery =
                    from u in db.User
                    where u.Username == username
                    select new { u.UserId, u.Password };

                if (!userQuery.Any())
                    return LoginValidationResult.UsernameNotFound;

                var queryResult = userQuery.Single();

                if (queryResult.Password == password)
                {
                    userId = queryResult.UserId;
                    return LoginValidationResult.Success;
                }
                else
                { 
                    return LoginValidationResult.IncorrectPassword;
                }
            }
        }
    }
}
