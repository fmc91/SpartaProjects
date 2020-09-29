using System;
using System.Collections.Generic;
using System.Windows.Navigation;
using BlogitCrud;

namespace BlogitGui
{
    public class Controller
    {
        private NavigationWindow m_mainWindow;

        private CrudManager m_crudManager;

        private int? m_loggedInUserId;

        private string m_loggedInUser;

        public Controller(NavigationWindow mainWindow, CrudManager crudManager)
        {
            m_mainWindow = mainWindow;
            m_crudManager = crudManager;
        }

        public void Home()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                LoggedInUser = m_loggedInUser,
                RecentlyActiveBlogs = m_crudManager.GetRecentlyActiveBlogInfo(5),
                RecentPosts = m_crudManager.GetRecentPosts(10)
            };

            HomePage homePage = new HomePage(homeViewModel, this);

            m_mainWindow.Navigate(homePage);
        }

        public void Login(string username, string password)
        {
            LoginViewModel viewModel = new LoginViewModel();

            switch (m_crudManager.ValidateLogin(username, password, out int userId))
            {
                case LoginValidationResult.UsernameNotFound:

                    viewModel.ValidationError = true;
                    viewModel.ValidationMessage = "Username not recognised";

                    LoginPage loginPage1 = new LoginPage(viewModel, this);
                    m_mainWindow.Navigate(loginPage1);

                    break;

                case LoginValidationResult.IncorrectPassword:

                    viewModel.ValidationError = true;
                    viewModel.ValidationMessage = "Incorrect Password";

                    LoginPage loginPage2 = new LoginPage(viewModel, this);
                    m_mainWindow.Navigate(loginPage2);

                    break;

                case LoginValidationResult.Success:

                    m_loggedInUserId = userId;
                    m_loggedInUser = m_crudManager.GetUsername(userId);
                    Home();

                    break;
            }
        }

        public void Logout()
        {
            m_loggedInUserId = null;
            m_loggedInUser = null;

            LoginPage loginPage = new LoginPage(new LoginViewModel(), this);

            m_mainWindow.Navigate(loginPage);
        }

        public void NewPost()
        {
            if (m_loggedInUserId is int loggedInUser)
            {
                if (m_crudManager.UserHasBlog(loggedInUser))
                {
                    NewPostViewModel viewModel = new NewPostViewModel { LoggedInUser = m_loggedInUser };

                    NewPostPage newPostPage = new NewPostPage(viewModel, this);

                    m_mainWindow.Navigate(newPostPage);
                }
                else
                {
                    string message = "You need to create a blog before you can do that.";

                    CreateBlogPage(message, false);
                }
            }
            else
            {
                LoginPage();
            }
        }

        public void Post(string postTitle, string postContent)
        {
            if (m_loggedInUserId is int loggedInUserId)
            {
                m_crudManager.CreatePost(loggedInUserId, postTitle, postContent);

                MyPosts();
            }
            else
            {
                LoginPage();
            }
        }

        public void MyPosts()
        {
            if (m_loggedInUserId is int loggedInUserId)
            {
                if (m_crudManager.UserHasBlog(loggedInUserId))
                {
                    List<BlogPost> userPosts = m_crudManager.GetPostsByUserId(loggedInUserId);

                    MyPostsViewModel viewModel = new MyPostsViewModel
                    {
                        LoggedInUser = m_loggedInUser,
                        UserPosts = userPosts
                    };

                    MyPostsPage myPostsPage = new MyPostsPage(viewModel, this);

                    m_mainWindow.Navigate(myPostsPage);
                }
                else
                {
                    string message = "You need to create a blog before you can do that.";

                    CreateBlogPage(message, false);
                }
            }
            else
            {
                LoginPage();
            }
        }

        public void Profile()
        {
            if (m_loggedInUserId is int loggedInUserId)
            {
                if (m_crudManager.UserHasBlog(loggedInUserId))
                {
                    BlogInfo blogInfo = m_crudManager.GetBlogInfoByUserId(loggedInUserId);

                    BlogStats blogStats = new BlogStats
                    {
                        BlogId = blogInfo.BlogId,
                        ActiveSince = blogInfo.ActiveSince,
                        LatestPost = blogInfo.LatestPost,
                        PostCount = blogInfo.PostCount
                    };

                    ProfileViewModel viewModel = new ProfileViewModel
                    {
                        LoggedInUser = m_loggedInUser,
                        EmailAddress = m_crudManager.GetUserEmailById(loggedInUserId),
                        Name = blogInfo.Author,
                        BlogName = blogInfo.Name,
                        BlogCategory = blogInfo.Category,
                        BlogAbout = blogInfo.About,
                        BlogStats = blogStats
                    };

                    ProfilePage profilePage = new ProfilePage(viewModel, this);

                    m_mainWindow.Navigate(profilePage);
                }
                else
                {
                    string message = "You need to create a blog before you can do that.";

                    CreateBlogPage(message, false);
                }
            }
            else
            {
                LoginPage();
            }
        }

        public void SaveChangesToProfile(string emailAddress, string name, string blogName, string blogCategory, string blogAbout)
        {
            if (m_loggedInUserId is int loggedInUserId)
            {
                m_crudManager.ModifyUserDetails(loggedInUserId, emailAddress, name);
                m_crudManager.ModifyBlogDetails(loggedInUserId, blogName, blogCategory, blogAbout);
            }
            else
            {
                LoginPage();
            }
        }

        public void ViewBlog(int blogId)
        {
            ViewBlogViewModel viewModel = new ViewBlogViewModel
            {
                LoggedInUser = m_loggedInUser,
                BlogInfo = m_crudManager.GetBlogInfoById(blogId),
                Posts = m_crudManager.GetPostsByBlogId(blogId)
            };

            ViewBlogPage viewBlogPage = new ViewBlogPage(viewModel, this);

            m_mainWindow.Navigate(viewBlogPage);
        }

        public void EditPost(int postId)
        {
            BlogPost blogPost = m_crudManager.GetPostById(postId);

            EditPostViewModel viewModel = new EditPostViewModel
            {
                LoggedInUser = m_loggedInUser,
                PostId = postId,
                Title = blogPost.Title,
                Content = blogPost.Content
            };

            EditPostPage editPostPage = new EditPostPage(viewModel, this);

            m_mainWindow.Navigate(editPostPage);
        }

        public void SaveChangesToPost(int postId, string title, string content)
        {
            m_crudManager.ModifyPost(postId, title, content);

            MyPosts();
        }

        public void DeletePost(int postId)
        {
            m_crudManager.DeletePost(postId);

            MyPosts();
        }

        public void Signup(string username, string password, string emailAddress)
        {
            if (m_crudManager.UsernameInUse(username))
            {
                SignupViewModel viewModel = new SignupViewModel
                {
                    Username = username,
                    EmailAddress = emailAddress,
                    ValidationError = true,
                    ValidationMessage = "Username is already in use"
                };

                SignupPage signupPage = new SignupPage(viewModel, this);

                m_mainWindow.Navigate(signupPage);
            }
            else
            {
                m_crudManager.CreateUser(username, password, emailAddress);

                m_loggedInUserId = m_crudManager.GetUserId(username);

                m_loggedInUser = username;

                string message = "Congratulations, you've signed up! Time to set up your blog!";

                CreateBlogPage(message, true);
            }
        }

        public void SignupPage()
        {
            SignupPage signupPage = new SignupPage(new SignupViewModel(), this);

            m_mainWindow.Navigate(signupPage);
        }

        public void CreateBlogPage(string message, bool canSkip)
        {
            CreateBlogViewModel viewModel = new CreateBlogViewModel
            {
                LoggedInUser = m_loggedInUser,
                Message = message,
                CanSkip = canSkip
            };

            CreateBlogPage createBlogPage = new CreateBlogPage(viewModel, this);

            m_mainWindow.Navigate(createBlogPage);
        }

        public void CreateBlog(string userActualName, string blogName, string blogCategory, string blogAbout)
        {
            if (m_loggedInUserId is int loggedInUserId)
            {
                m_crudManager.SetUserActualName(loggedInUserId, userActualName);

                m_crudManager.CreateBlog(loggedInUserId, blogName, blogCategory, blogAbout);

                Home();
            }
            else
            {
                LoginPage();
            }
        }

        public void LoginPage()
        {
            LoginPage loginPage = new LoginPage(new LoginViewModel(), this);

            m_mainWindow.Navigate(loginPage);
        }
    }
}
