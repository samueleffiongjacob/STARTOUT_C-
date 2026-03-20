namespace STARTOUT_C_.BasicConcerpt.dateAndTime
{
    class dateAndTime
    {
        public dateAndTime()
        { 
            // Get the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current date and time: " + now);
            // Get the current date
            DateTime today = DateTime.Today;
            Console.WriteLine("Current date: " + today.ToShortDateString());
            // Get the current time
            TimeSpan currentTime = now.TimeOfDay;
            Console.WriteLine("Current time: " + currentTime);
            // Format the date and time
            string formattedDate = now.ToString("MMMM dd, yyyy");
            string formattedTime = now.ToString("hh:mm tt");
            Console.WriteLine("Formatted date: " + formattedDate);
            Console.WriteLine("Formatted time: " + formattedTime);
        }
    }
}
