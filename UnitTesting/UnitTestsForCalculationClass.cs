using WSUniversalLib;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestsForCalculationClass
    {
        [TestMethod]
        public void CalculationNonExistentProductType()
        {
            Calculation calc = new Calculation();

            int productType = 2;
            int materialType = 1;
            int count = 24;
            float width = 22f;
            float lenght = 11f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);
            

        }

        [TestMethod]
        public void CalculationNonExistentMatType()
        {
            Calculation calc = new Calculation();

            int productType = 2;
            int materialType = -3;
            int count = 12;
            float width = 32f;
            float lenght = 44f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }
        [TestMethod]
        public void CalculationIfMaxNumberProductType()
        {
            Calculation calc = new Calculation();

            int productType = 50000;
            int materialType = 1;
            int count = 5;
            float width = 12f;
            float lenght = 65f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }

        [TestMethod]
        public void CalculationIfMinNumberProductType()
        {
            Calculation calc = new Calculation();

            int productType = -50000;
            int materialType = 1;
            int count = 2;
            float width = 17f;
            float lenght = 32f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }

        [TestMethod]
        public void CalculationIfCountLessThanZero()
        {
            Calculation calc = new Calculation();

            int productType = 1;
            int materialType = 1;
            int count = -43;
            float width = 76f;
            float lenght = 45f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }

        [TestMethod]
        public void CalculationIfWidthLessThanZero()
        {
            Calculation calc = new Calculation();

            int productType = 1;
            int materialType = 1;
            int count = 12;
            float width = -12f;
            float lenght = 45f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }

        [TestMethod]
        public void CalculationIfLenghthLessThanZero()
        {
            Calculation calc = new Calculation();

            int productType = 1;
            int materialType = 1;
            int count = 54;
            float width = 55f;
            float lenght = -43f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }

        [TestMethod]
        public void CalculationIfWidthAndLengthLessThanZero()
        {
            Calculation calc = new Calculation();

            int productType = 1;
            int materialType = 1;
            int count = 22;
            float width = -55f;
            float lenght = -43f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }
        [TestMethod]
        public void CalculationIfCountEqualZero()
        {
            Calculation calc = new Calculation();

            int productType = 1;
            int materialType = 1;
            int count = 0;
            float width = 55f;
            float lenght = 43f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }
        [TestMethod]
        public void CalculationIfLengthEqualZero()
        {
            Calculation calc = new Calculation();

            int productType = 1;
            int materialType = 1;
            int count = 22;
            float width = 55f;
            float lenght = 12f;

            int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
            Console.WriteLine(materialQuant);


        }
        //[TestMethod]
        //public void test()
        //{
        //    Calculation calc = new Calculation();

        //    int productType = -22;
        //    int materialType = -12;
        //    int count = -65;
        //    float width = -14f;
        //    float lenght = -55f;

        //    int materialQuant = calc.GetQuantityForProduct(productType, materialType, count, width, lenght);
        //    Console.WriteLine(materialQuant);


        //}

    }
}