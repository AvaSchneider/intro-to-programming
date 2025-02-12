
public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
            return 0;
        else
        {
            if (!numbers.Contains(",") && !numbers.Contains('\n'))
            {
                return int.Parse(numbers);
            }
            else 
            {
                char[] delimiters = new char[0];

                if (!numbers.Contains('\n'))
                {
                    delimiters = new char[] { ',' };
                }
                else if (!numbers.Contains(","))
                {
                    delimiters = new char[] { '\n' };
                }
                else { 
                    delimiters = new char[] {',', '\n'};
                }
                string[] individualNumbers = numbers.Split(delimiters);
                int addedNumbers = 0;
                foreach (string num in individualNumbers)
                { 
                    int number = int.Parse(num);
                    addedNumbers += number;
                }
                return addedNumbers;
            }
        }
    }
}
