using System;
namespace RWG.Models
{
	public class Progress
	{
		public int Id { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public DateOnly Date { get; set; }
    }
}

