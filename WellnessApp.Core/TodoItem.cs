using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WellnessApp.Core
{
    public class TodoItem
    {
        [Key]
        public int TodoItemID { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int PointsEarned { get; set; }
    }
}
