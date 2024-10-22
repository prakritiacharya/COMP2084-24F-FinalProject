namespace Assignment2.Models
{
    public class WorkoutPlan
    {
        public int WorkoutPlanId { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
