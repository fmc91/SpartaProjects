using System;
using System.Linq;
using BlogitEntityModel;

namespace DataGenerate
{
    public class Program
    {
        static void Main()
        {
            AddUser("johnny84", "password", "j.stevens@mail.com", "John Stevens", new DateTime(2017, 8, 14));
            AddUser("freddyG", "password", "f.goodwin@mail.com", "Fred Goodwin", new DateTime(2018, 1, 3));
            AddUser("superstar92", "password", "s.hamilton@mail.com", "Sharon Hamilton", new DateTime(2018, 4, 21));
            AddUser("pennyw123", "password", "p.wood@mail.com", "Penelope Wood", new DateTime(2018, 7, 12));
            AddUser("shiftyshabz7", "password", "s.khusravi@mail.com", "Shahbaz Khusravi", new DateTime(2018, 12, 2));

            AddBlog("johnny84", "Kitchen Craft",
                "All the greatest and most innovative recipes to cook up delicious dishes which will have you and your " +
                "friends and family watering at the mouth.");

            AddBlog("freddyG", "Gaming Genie",
                "News and reviews about all types of video games from an unbiased and reputable source. Whether you like " +
                "shooters, racing games or RPGs, we have it all, on PC, PS4 and Xbox.");

            AddBlog("superstar92", "The Wandering Nomad",
                "Welcome to my travel blog! I am an avid adventurer and frequently trek to the far reaches of the globe " +
                "in search of new experiences! You will find all my travels documented right here, from treks in the Sahara " +
                "to basking on a beach in the Maldives!");

            AddBlog("pennyw123", "Watchful Eye",
                "I am a political blogger, sharing my views on political issues in the United States. I am a staunch " +
                "conservative and will not hesitate to stand up for gun rights and pro-life issues.");

            AddBlog("shiftyshabz7", "Code Campus",
                "A tech blog dedicated to making you a master at coding. I cover all the latest trendy frontend javascript " +
                "frameworks which will make you a hit with the hipster coding crowd. Also stay tuned for interview tips " +
                "to help you score a position with a FANG company!");

            AddPost("johnny84", "Fried Chicken",
                "Today, I'm going to show you how I make my delicious, mouth-watering fried chicken, complete with cripsy " +
                "coating. To make the seasoning, mix two cups of flour with salt, black pepper, paprika, onion powder " +
                "and garlic powder. First, lightly coat the chicken with flour, then dip it in the egg wash, and finally, " +
                "give it a liberal coat of seasoning. Then, heat up the oil to 180C and deep fry until golden brown.",
                new DateTime(2017, 8, 17));

            AddPost("johnny84", "Heavenly Cupcakes",
                "Today, I'm going to show you how to make truly heavenly cupcakes! First, cream together the butter and " +
                "sugar. Then, whisk in the eggs, and finally add the flour. Mix together until you reach a smooth " +
                "consistency but be sure not to over-mix. To make the frosting, mix together butter and icing sugar, " +
                "add a dash of cream and add some vanilla extract. Use a piping bag with a star nozzle to apply the frosting.",
                new DateTime(2017, 9, 8));

            AddPost("freddyG", "The Witcher 3: Wild Hunt",
                "I just got my hands on The Witcher 3, and boy, is it absolutely breathtaking! Geralt of Rivia returns in " +
                "this latest installment, teaming up with his lover Yennefer to search for his adoptive daughter Ciri. " +
                "The game world is truly vast, and there will always be something new to discover, even after dozens of " +
                "hours of exploration. The game makes you an active participant in the story, allowing you to make choices " +
                "which will impact how the rest of the narrative unfolds. 10/10",
                new DateTime(2018, 1, 17));

            AddPost("freddyG", "Metal Gear Solid V: The Phantom Pain",
                "In the latest installment of the Metal Gear Solid series, Konami have a added an open-world twist to the " +
                "usual stealth formula. Playing as Venom Snake, you will be deployed to remote regions such as Afghanistan " +
                "where you will be able to perform reconnaissance on infiltration targets from afar. Each mission can be " +
                "apporached in several different ways and it us up to you to determine your strategy and play style. In " +
                "addition, you will be responsible for building up your very own private militia which will provide you " +
                "with a steady stream of income. You can recruit enemy soldiers you encounter in the field in order to " +
                "exploit their special skills. 8/10",
                new DateTime(2018, 6, 25));

            AddPost("superstar92", "Paris",
                "Hi guys! Today I am in Paris and it is awesome! I arrived yesterday afternoon and spent the day strolling " +
                "around central Paris, just taking in the sights - I love the ambience of the place! I just had a French " +
                "breakfast and now I'm heading off to spend a day at the Louvre! Will keep you guys posted!",
                new DateTime(2018, 5, 6));

            AddPost("superstar92", "Grand Canyon",
                "Hi guys! Today I am visiting the Grand Canyon in America, and oh my gosh, is it absolutely boiling! The " +
                "moment I stepped off the air-conditioned coach it just hit me like a furnace, and it hasn't let up since. " +
                "But back on topic, this place is stunning, absolutely breathtaking! I'm looking forward to going on a little " +
                "hike and seeing some more spectacular views. I'm glad I brought plenty of water as I'm certainly going to " +
                "need it!",
                new DateTime(2018, 9, 23));

            AddPost("pennyw123", "Right to Bear Arms",
                "I am feeling very angry today because of liberals who think it is constitutional to take away our right " +
                "to bear arms. Well, this is my message to you: you can't take away our guns. It is our second amendment " +
                "right to bear arms. Guns are a fundamental part of being an American. Taking away people's guns will not " +
                "make society any safer. It will take away our freedom and make society a more dangerous place.",
                new DateTime(2018, 7, 28));

            AddPost("shiftyshabz7", "HTML",
                "Hi guys. Today we are going to learn about HTML. HTML is one of the building blocks of the world wide web " +
                "and is the first step on your journey towards becoming a web developer. HTML defines the structure of a " +
                "web page using tags. Tags are written in angled brackets, like this: <body>. This is an example of an opening " +
                "tag. A corresponding closing tag would be the same, but including a slash, like this: </body>. Anything that " +
                "goes in between the opening and closing \"body\" tags would be part of the \"body\" element.",
                new DateTime(2018, 12, 19));

            AddPost("shiftyshabz7", "Javascript Basics",
                "Hi guys. Today, we are going to learn the basics of Javascript. Javascript is arguably the most popular " +
                "programming language in the world today, and will take you a long way in your web development career. " +
                "Javascript is the key to making web pages interactive, and all the trendy frontend frameworks like React, " +
                "Angular and Vue are based on Javascript. Today we are going to start off by learning about variables. A " +
                "variable is basically just like a place where you hold data. For example, if I write 'let x = 10;' that would " +
                "store the value 10 inside the variable x. I can then change the value stored inside x if I want, for example " +
                "by writing 'x = 12;'. But what if I wrote 'x = x + 4;'? What do you think would happen then?",
                new DateTime(2019, 2, 21));
        }

        static void AddUser(string username, string password, string emailAddress, string name, DateTime joinDate)
        {
            using (BlogitContext db = new BlogitContext())
            {
                User newUser = new User
                {
                    Username = username,
                    Password = password,
                    EmailAddress = emailAddress,
                    Name = name,
                    JoinDate = joinDate
                };

                db.User.Add(newUser);

                db.SaveChanges();
            }

            Console.WriteLine($"Added User '{username}'");
        }

        static void AddBlog(string username, string name, string about)
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

                Blog newBlog = new Blog
                {
                    UserId = userId,
                    Name = name,
                    About = about
                };

                db.Blog.Add(newBlog);

                db.SaveChanges();
            }

            Console.WriteLine($"Added blog '{name}' for user '{username}'");
        }

        static void AddPost(string username, string title, string content, DateTime date)
        {
            using (BlogitContext db = new BlogitContext())
            {
                int blogId =
                (
                    from u in db.User
                    join b in db.Blog on u.UserId equals b.UserId
                    where u.Username == username
                    select b.BlogId
                )
                .Single();

                Post newPost = new Post
                {
                    BlogId = blogId,
                    Title = title,
                    Content = content,
                    Date = date
                };

                db.Post.Add(newPost);

                db.SaveChanges();
            }

            Console.WriteLine($"Added blog post for user '{username}' with title '{title}'");
        }
    }
}
