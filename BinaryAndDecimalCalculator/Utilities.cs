using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryAndDecimalCalculator
{
    public class BinaryToDecimal
    {
        #region Fields
        private string binaryString;
        private int result;
        #endregion
        #region Properties
        /// <summary>
        ///Controls access to field called results 
        /// </summary>
        public int ResultofProgram
        {
            get         
            {
                return result;
            }
            set
            {
                if(value >= 0)
                    result = value;
            }
        }
        /// <summary>
        /// controls access to binaryString field
        /// </summary>
        public string BinaryString
        {
            get
            {
                return binaryString;
            }
            set
            {
                binaryString = value;
            }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// not really necessary but created in case I decide
        /// later I need it.
        /// </summary>
        public BinaryToDecimal()
        {
            result = 0;
            BinaryString = string.Empty;
        }
        #endregion
        #region Methods
        /// <summary>
        /// I need a more decriptive name. For now this is fine.
        /// </summary>
        /// <returns></returns>
        public bool StartsWithBinary()
        {
            if (VerifyBinary(BinaryString))
            {
                result = CalculateDecimal(BinaryString);
                return true;
            }
            else
                MessageBox.Show("Please enter a binary number");
            return false;
        }
        /// <summary>
        /// This does the calculation of binary to decimal
        /// </summary>
        /// <param name="binaryInString"></param>
        /// <returns></returns>
        public int CalculateDecimal(string binaryInString)
        {
            int result = 0;
            binaryInString = Reverse(binaryInString);
            for (int i = binaryInString.Length-1; i >= 0; i--)
            {
                if (int.Parse(binaryInString[i].ToString()) == 1)
                    result += (int)Math.Pow(2, i);
            }
            return result;
        }
        /// <summary>
        /// Reverses the string given. This is needed for the algorithm
        /// in CalculateDecimal to work.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        /// <summary>
        /// Verifies that the string contains a binary number.
        /// I might delete this and due the validation in the properties.
        /// </summary>
        /// <param name="binaryInString"></param>
        /// <returns></returns>
        public static bool VerifyBinary(string binaryInString)
        {
            bool verified = true;
            for (int counter = 0; counter < binaryInString.Length; counter++)
            {
                if (int.Parse(binaryInString[counter].ToString()) == 1 || int.Parse(binaryInString[counter].ToString()) == 0)
                {
                    continue;
                }
                else
                {
                    verified = false;
                    break;
                }
            }
            return verified;
        }
        #endregion
    }
    public class DecimalToBinary
    {
        #region Fields
        private static StringBuilder decimalString = new StringBuilder();
        private static StringBuilder result = new StringBuilder();
        #endregion
        #region Properties
        /// <summary>
        /// controls access to field decimalString
        /// </summary>
        public StringBuilder DecimalString
        {
            get
            {
                return decimalString;
            }
            set
            {
                decimalString = value;
            }
        }
        /// <summary>
        /// controls access to the field result
        /// </summary>
        public StringBuilder Result
        {
            get
            {
                return result;
            }
            set
            {               
                result = value;
            }
        }
        #endregion
        #region Constructor
        /// <summary>
        /// not really needed but there in case the need arises.
        /// </summary>
        public DecimalToBinary()
        {
            Result.Clear();
            DecimalString.Clear();
        }
        #endregion
        #region Methods
        /// <summary>
        /// takes the string from Form1 and starts the calculation.
        /// Probably need to change to to work with the properties, which 
        /// should do the validation.
        /// </summary>
        /// <param name="decString"></param>
        public void InputForDecimal(string decString)
        {
            decimalString.Clear();
            if (VerifyDecimal(decString))
                result = CalculateBinary(decString);
            else
                MessageBox.Show("Please enter a valid natural number");
        }
        /// <summary>
        /// Verifies that the string holds a decimal number
        /// temporary as this should happen in properties.
        /// </summary>
        /// <param name="decimalInString"></param>
        /// <returns></returns>
        public bool VerifyDecimal(string decimalInString)
        {
            int n;
            if (int.TryParse(decimalInString, out n))
                return true;
            return false;
        }
        /// <summary>
        /// Does the calculation of decimal to binary
        /// </summary>
        /// <param name="decimalInString"></param>
        /// <returns></returns>
        public StringBuilder CalculateBinary(string decimalInString)
        {
            bool divided = true;
            int divisor = 1;
            int Decimal = int.Parse(decimalInString); // change try parse
            while (divided)
            {
                if ((Decimal / divisor) > 1)
                {
                    divisor *= 2;
                    continue;
                }
                else
                    divided = false;
            }
            while (divisor > 0)
            {
                if ((Decimal % divisor >= 1 && Decimal > divisor) || Decimal == divisor)
                {
                    Decimal = Decimal % divisor;
                    decimalString.Append("1");
                }
                else
                    decimalString.Append("0");
                divisor /= 2;
            }
            return decimalString;
        }
        #endregion
    }
}
