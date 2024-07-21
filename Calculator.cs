
 public  class Calculator
    {
      public double FirstOprator { get; set; }
      public double SecondOprator { get; set; }
      private double _result;
       private string? _operand;

        public string  Operand
        {
           set
           {
            if( value == "+"||
               value == "-"||
               value == "*" ||
               value == "/")
            {
             _operand = value;
            }
           }
            
        }

        
        public void Process()
      {
        switch (_operand)
        {
          case "+":
            _result = (FirstOprator + SecondOprator);
            break;
          case "-":
            _result = (FirstOprator - SecondOprator);
             break;
          case "*":
            _result = (FirstOprator * SecondOprator);
             break;
          case "/":
            _result = (FirstOprator / SecondOprator);
             break;
          default:
            throw new Exception("That was not a valid option");
        }
      }

        public void PrintOption()
        {
            Console.WriteLine("Option:");
          Console.WriteLine("+ : Add");
          Console.WriteLine("- : Substract");
          Console.WriteLine("* : Multiply");
          Console.WriteLine("/ : Divide");
          Console.WriteLine("Enter an option:");

        }

        public override string ToString()
        {
            return $"Your result : {FirstOprator} {_operand} {SecondOprator} = {_result}";
        }

     
    }