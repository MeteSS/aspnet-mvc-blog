using Blog.Data.Entity;

namespace Blog.Data
{
	public class DbSeeder
	{
		public static void Seed(AppDbContext context)
		{
			if (!context.Categories.Any())
			{
				// Kategorileri oluşturma
				var categories = new Category[]
				{
					new Category { Name = "Teknoloji", Slug = "teknoloji" },
					new Category { Name = "Yaşam", Slug = "yasam" },
					new Category { Name = "Sağlık", Slug = "saglik" },
					new Category { Name = "Hayat", Slug = "hayat" }
				};

				context.Categories.AddRange(categories);
				context.SaveChanges();
			}
            if (!context.Users.Any())
            {
                context.Users.Add(new User { Name = "Admin1" ,Email="admin@gmail.com",Password="adminadmin",Phone="055555555", City="Erzincan", Roles ="Admin,"});
                context.Users.Add(new User { Name = "Mete" ,Email="mEte@gmail.com",Password="Metemete",Phone="0636235463", City="Kayseri",});


                context.SaveChanges();
            }
            if (!context.Posts.Any())
			{
				// Yazıları oluşturma
				var posts = new Post[]
				{
					new Post { Title = "Lorem Ipsum", Content = "Cras ut metus a risus iaculis scelerisque eu ac ante fusce non varius purus aenean nec magna felis fusce vestibulum velit mollis odio sollicitudin lacinia aliquam posuere, sapien elementum lobortis tincidunt, turpis dui ornare nisl, sollicitudin interdum turpis nunc eget sem nulla eu ultricies orci praesent id augue nec lorem pretium congue sit amet ac nunc fusce iaculis lorem eu diam hendrerit at mattis purus dignissim vivamus mauris tellus, fringilla vel dapibus a, blandit quis erat vivamus elementum aliquam luctus.", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 1),context.Categories.FirstOrDefault(e => e.Id == 4) },UserId=1},
					new Post { Title = "Yaşama Dair", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 2) },UserId=1},
					new Post { Title = "Sağlık Haberleri", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ", Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 3) },UserId=1},
					new Post { Title = "Hayat Kalitesi", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ",Categories=new List<Category>{context.Categories.FirstOrDefault(e => e.Id == 4) },UserId=1}
				};
				
				context.Posts.AddRange(posts);
				context.SaveChanges();
			}
            if (!context.Pages.Any())
            {
                // Yazıları oluşturma
                var pages = new Page[]
                {
                    new Page { Title = "Sayfa"}
                   
                };

                context.Pages.AddRange(pages);
                context.SaveChanges();
            }
			if (!context.PostImages.Any())
			{
				var images = new PostImage[]
				{
					new PostImage{ PostId = 1, ImagePath="deneme"},
				};

                context.PostImages.AddRange(images);
                context.SaveChanges();
            }
        }
	}
}
