namespace Internal
{
    // default is internal
    // Accessible only in the same assembly
    class Internal 
    {
        public static int alpha = 12;
        int a = Public.Internal;
    }

    public class Public 
    {
        // Accessible only in the same assembly in derived or external classes
        internal static int Internal = 12;
        protected static string name = "Shehenshah";
        private protected static bool accessible = false;
    }

    public static class Extension
    {
        public static void showExtension(this Public obj, string message)
        {
            System.Console.WriteLine(message);
        }
    }

    public class ChildOfPublic : Public
    {
        public static void show(){
            System.Console.WriteLine(Internal);
            System.Console.WriteLine(name);
            System.Console.WriteLine(accessible);
        }
    }
}