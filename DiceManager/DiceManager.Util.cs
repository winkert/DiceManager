using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DiceManager
{
    public static class Util
    {
        private static Random r = new Random();
		/// <summary>
        /// Roll a set of dice and return the result
        /// </summary>
        /// <param name="d">dice type</param>
        /// <param name="n">number of dice</param>
        /// <param name="b">bonus</param>
        /// <returns>new int</returns>
        public static int RollDice(int d, int n, int b = 0)
        {
            int roll = 0;
            for (int i = 0; i < n; i++)
            {
                roll += r.Next(1, d + 1);
            }
            return roll + b;
        }
		/// <summary>
        /// Roll a set of dice and return the result
        /// </summary>
        /// <param name="rollText">text representation of a roll (1d20+1)</param>
        /// <returns>new int</returns>
		public static int RollDice(string rollText)
        {
            try
            {
                string roll = rollText;
                int d, n, b;
                int toD = roll.ToLower().IndexOf('d');
                int toBonus = roll.ToLower().IndexOf('+') > -1 ? roll.ToLower().IndexOf('+') : roll.ToLower().IndexOf('-');
                if (toBonus > -1)
                {
                    if (!int.TryParse(roll.Substring(toBonus + 1, roll.Length - (toBonus + 1)).Trim(), out b))
                        b = 0;
                    roll = roll.Substring(0, toBonus);
                }
                else
                    b = 0;
                if (!int.TryParse(roll.Substring(0, toD).Trim(), out n))
                    n = 0;
                if (!int.TryParse(roll.Substring(toD + 1, roll.Length - (toD + 1)).Trim(), out d))
                    d = 0;
                return RollDice(d, n, b);
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
		/// <summary>
        /// Save an array of strings into an xml file
        /// </summary>
        /// <param name="buttons">list of strings representing the buttons</param>
        /// <param name="file">save file location</param>
		public static void SerializeRolls(List<string> buttons, string file)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<string>));
                using (TextWriter t = new StreamWriter(file))
                {
                    ser.Serialize(t, buttons);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
		/// <summary>
        /// Load an array of strings from an xml file
        /// </summary>
        /// <param name="file">save file location</param>
        /// <returns>list of strings representing buttons in xml file</returns>
		public static List<string> DeserializeRolls(string file)
        {
            try
            {
                List<string> buttons;
                XmlSerializer deser = new XmlSerializer(typeof(List<string>));
                TextReader r = new StreamReader(file);
                buttons = (List<string>)deser.Deserialize(r);
                return buttons;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
