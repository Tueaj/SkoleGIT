namespace ECS.refarctored
{
    public class Application
    {
        public static void Main(string[] args)
        {
            var ecs = new EECS(28);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
