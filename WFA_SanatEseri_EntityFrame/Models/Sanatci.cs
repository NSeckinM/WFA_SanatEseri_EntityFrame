using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SanatEseri_EntityFrame.Models
{
    [Table("Sanatcilar")]
    public class Sanatci
    {

        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Ad { get; set; }


        /// <summary>
        /// /virtual koydugunuzda bu navigation property de
        /// layz loading yapar yani normalde snatcının eserlerini getirmez ihtiyac anında db de eser table ile join yapar ve getirir  
        /// </summary>
        public virtual ICollection<Eser> Eserler { get; set; }


    }
}
