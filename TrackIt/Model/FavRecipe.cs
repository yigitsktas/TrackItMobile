using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackIt.Model
{
    public class FavRecipe
    {
        public int FavRecipeID { get; set; }
        public int MemberID { get; set; }
        public int RecipeID { get; set; }
    }
}
