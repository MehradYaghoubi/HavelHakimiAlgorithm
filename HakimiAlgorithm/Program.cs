

HavelHakimi App = new();
App.Start();

public sealed class HavelHakimi
{
    public (bool,string) IsGraphicSequence(List<int> degrees)
    {
        int step = 1;

        degrees.Sort();
        degrees.Reverse();

        DisplayMessage("PROCESSING_SEQUENCE_Sorted", degrees);

        //درصورتی که کل درجه ها صفر باشن به هرحال گراف تشکیل میشه
        degrees.RemoveAll(d => d == 0);
        if (!degrees.Any()) return (true, DisplayMessage("GRAPHIC_ZERO"));

        while (degrees.Count > 1)
        {

            // گرفتن بزرگترین مقدار و حذف آن
            int n = degrees[0];
            degrees.RemoveAt(0);

            // اگر بزرگترین درجه بیشتر از تعداد گره‌ها باشد، گرافیک نیست
            if (n > degrees.Count)
            {
                DisplayMessage("STEP", step, degrees);
                return (false, DisplayMessage("TOO_LARGE_DEGREE" , n, degrees.Count));
            }


            //میشد از یک حلقه استفاده کرد اما برای نمایش بهتر پاسخ ها از دوتا حلقه استفاده کردم 
            // کاهش درجات
            for (int i = 0; i < n; i++) degrees[i]--;


            DisplayMessage("STEP", step, degrees);

            //بررسی درجه منفی
            for (int i = 0; i < n; i++) if (degrees[i] < 0) return (false, DisplayMessage("NEGATIVE_DEGREE"));


            step++;
        }


        return  degrees[0] == 0
            ? (true, DisplayMessage("GRAPHIC_FINAL"))
            : (false, DisplayMessage("NON_GRAPHIC_FINAL"));
    }

    public void Start()
    {
        List<int> degrees;

        while (true)
        {
            DisplayMessage("INPUT_REQUEST");
            string input = Console.ReadLine();

            // اعتبارسنجی ورودی
            if (string.IsNullOrWhiteSpace(input))
            {
                DisplayMessage("INVALID_INPUT");
                continue;
            }

            degrees = input.Split(',')
                .Select(s => int.TryParse(s.Trim(), out int result) ? result : -1)
                .Where(x => x >= 0)
                .ToList();

            if (degrees.Count == 0)
            {
                DisplayMessage("INVALID_INPUT");
                continue;
            }

            
            DisplayMessage("PROCESSING_SEQUENCE", degrees);
            DisplayMessage("FINAL_RESULT", IsGraphicSequence(degrees).Item2);
        }
        

    }

    private string DisplayMessage(string messageCode, object param1 = null, object param2 = null)
    {
        switch (messageCode)
        {
            case "INPUT_REQUEST":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPlease enter a degree sequence (e.g., 3,3,2,2,2,1):");
                Console.ResetColor();
                break;

            case "INVALID_INPUT":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID INPUT: Please enter a valid sequence of numbers separated by commas.");
                Console.ResetColor();
                break;

            case "PROCESSING_SEQUENCE":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nProcessing sequence: [{string.Join(", ", (List<int>)param1)}]");
                Console.ResetColor();
                break;

            case "PROCESSING_SEQUENCE_Sorted":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nProcessing sequence after sort: [{string.Join(", ", (List<int>)param1)}]");
                Console.ResetColor();
                break;

            case "STEP":
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Step {param1}: [{string.Join(", ", (List<int>)param2)}]");
                Console.ResetColor();
                break;

            case "TOO_LARGE_DEGREE":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR: The Selected node with degree {param1} is greater than the remaining nodes, which are equal to {param2} .");
                Console.ResetColor();
                return "The sequence is not graphic because a node has a degree equal to or greater than the total number of nodes.";

            case "NEGATIVE_DEGREE":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: A negative degree has been encountered, which is not possible.");
                Console.ResetColor();
                return "The sequence is not graphic because a node has a negative degree.";

            case "GRAPHIC_ZERO":
                return "The sequence is graphic because all nodes have a degree of zero.";

            case "GRAPHIC_FINAL":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" SUCCESS: The sequence is graphic.");
                Console.ResetColor();
                return "The sequence is graphic because the last remaining node has a degree of zero.";

            case "NON_GRAPHIC_FINAL":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: The last remaining node has a degree greater than zero.");
                Console.ResetColor();
                return "The sequence is not graphic because the last remaining node has a degree greater than zero.";

            case "FINAL_RESULT":
                Console.WriteLine($"Final Result: {param1}");
                break;
        }

        return "";
    }
}
