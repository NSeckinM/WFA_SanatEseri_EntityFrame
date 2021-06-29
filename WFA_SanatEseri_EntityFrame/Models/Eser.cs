using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SanatEseri_EntityFrame.Models
{
    [Table("Eserler")]
    public class Eser
    {

        public int Id { get; set; }


        [Required,MaxLength(50)]
        public string Ad { get; set; }

        public int? Yil { get; set; }

        // sanatcı + ıd : sanatcı entitysinin ıd sine referans veren fk
        //isiminden dolayı forein key oldugunu anlayacak bunun  ama bunu anlayabilmesi için iki clas arasında bir tanesinde
        // navigation property olmalı ki bağlantıyı anlasın.
        public int SanatciId { get; set; }

        public virtual Sanatci Sanatci { get; set; }

    }
}
