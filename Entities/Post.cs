using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using WebProjectAPI.Entities.IdentityModel;

namespace WebProjectAPI.Entities
{
    public class Post
    {
        public Post() {

            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Describe { get; set; }


        [DataType(DataType.Text)]
        public string Content { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual AppUser AppUser {get; set;}

    }
}
