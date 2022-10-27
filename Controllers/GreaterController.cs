//Name: Ulises Ortega
//Date: 10.25.22
//Project: Greater or Less Than
//Description: This Endpoint Evaluate 2 numbers and oupt if greater or less than or equal.
//Peer Review: Elizar Garcia, Code works great! i really like the layout and how it gives all of the outcomes for the numbers you enter, very nice!
//code is clean and easy to read, also shows up on postman with no problem. Great job!

//Description: This Endpoint request the user to input two numbers for comparison, the Endpoint will evaluate the 2 numbers and output if greater or less than or equal.
//When you Run and Debug the endpoint you will get a diferent local host than the one in the last line
//folow the same structure, replace number1 and number 2 with your own numbers.
//https://localhost:7153/Greater/Number/Number1/Number 2


using Microsoft.AspNetCore.Mvc;
namespace OrtegaUGreater_Than_Or_Less_Than___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterController : ControllerBase
{
    [HttpGet]
    [Route("Number/{number1}/{number2}")]
    
    public string Number(string number1, string number2)
    {
        string result = "";
        int Num1 = Convert.ToInt32(number1);
        int Num2 = Convert.ToInt32(number2);

        if (Num1 > Num2)
        {
            result = ($"{Num1} is greater than {Num2} \n{Num2} is less than {Num1} \n{Num1} is not equal to {Num2}");
        }
        if (Num1 < Num2)
        {
            result = ($"{Num1} is less than {Num2} \n{Num2} is greater than {Num1} \n{Num1} is not equal to {Num2}");
        }
        if (Num1 == Num2)
        {
            result = ($"{Num1} is not less than {Num2} \n{Num2} is not greater than {Num1} \n{Num1} is equal to {Num2}");
        }
        return result;
    }
}
