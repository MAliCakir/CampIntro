class Program
{
    private static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 20;
        number1 = number2;
        number2 = 30;
        //if we want to print number1, what would be the value of number1 ?
        //the answer will be 20 because we are just changing number1 value

        int[] numbers1 = { 10,20,30};
        int[] numbers2 = { 100, 200, 300 };
        numbers1 = numbers2;
        numbers2[0] = 999;

        //if we want to print number1[0], what would be the value of number1[0]? 
        // the answer will be 999 because we are changing numbers1 reference value
        //arrays types reference 
        // int, double,decimal,float these are value types
        //array,class,interface these are reference types
        //value types are stored in the stack and reference types
        //are stored in the heap

    }
}