namespace Counter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCounter")]
    public partial class tblCounter
    {
        public int Id { get; set; }

        public int Count { get; set; }
    }
}
