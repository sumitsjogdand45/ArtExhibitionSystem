using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.domain;

namespace ArtExhibitionSystem.Domain
{
    public class FavoriteArtWork
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavouriteArtWorkId { get; set; }
        public int UserId { get; set; }
       

        public int ArtworkId { get; set; }
        public Artworks Artworks { get; set; }
    }
}
