using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebProjectAPI.Entities.IdentityModel;

namespace WebProjectAPI.Dto
{
    public class PostDto
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Describe { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }

    }
}
