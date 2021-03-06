﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teleoffice.Models
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Message { get; set; }
        public DateTime ReceivedTime { get; set; }
        public int Read { get; set; }
        public String UserId { get; set; }
        public int Status { get; set; }
        public ApplicationUser User { get; set; }
    }
}
