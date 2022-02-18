namespace CyberHullTraining.Challenges.Second
{
    internal sealed class SecondChallenge : IChallenge
    {
        public void Act()
        {
            //I would rather use constants, cause magic numbers are always bad practice, but I'm lazy to do it here, sorry...
            byte b = 255;
            sbyte sb = 127;
            int i = -2_147_483_648;
            uint ui = 4_294_967_295;
            short s = -32_768;
            ushort us = 65535;
            long l = -9_223_372_036_854_775_808;
            ulong ul = 18_446_744_073_709_551_615;
            float f = -0.3f;
            double d = -0.3464356;
            char c = '!';
            bool bo = true;
            string str = "text";
            decimal dec = decimal.MaxValue;

            string output =
                "byte value: " + b.ToString() + Environment.NewLine +
                "sbyte value: " + sb.ToString() + Environment.NewLine +
                "int value: " + i.ToString() + Environment.NewLine +
                "uint value: " + ui.ToString() + Environment.NewLine +
                "short value: " + s.ToString() + Environment.NewLine +
                "ushort value: " + us.ToString() + Environment.NewLine +
                "long value: " + l.ToString() + Environment.NewLine +
                "ulong value: " + ul.ToString() + Environment.NewLine +
                "float value: " + f.ToString() + Environment.NewLine +
                "double value: " + d.ToString() + Environment.NewLine +
                "char value: " + c.ToString() + Environment.NewLine +
                "bool value: " + bo.ToString() + Environment.NewLine +
                "string value: " + str + Environment.NewLine +
                "decimal value: " + dec.ToString() + Environment.NewLine;

            Console.WriteLine(output);
        }
    }
}
