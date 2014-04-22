namespace LoLStats_Backend
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ => "Hello World!";
        }
    }
}