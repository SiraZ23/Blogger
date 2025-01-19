namespace Blogger.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        //Navigation Property
        public ICollection<BlogPost> blogPosts { get; set; }
        //This represents that 1 Tag can have Many BlogPost
    }
}
