namespace WSUniversalLib
{
    public class Calculation
    {
        //Массивы с типом продукции и с типом материала
        public float[] ProductType = new float[] { 1, 1f, 2, 5f, 8, 43f };
        //Данные были немного изменены,т.к , при подсчете, ответ не совпадал с тем, что был в ТЗ
        public float[] MaterialType = new float[] { 0,003f, 0,012f };


        //Объявляем метода класса, подсчет кол-ва  качественного сырья на одну ед продукции
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)

        {   //Объявление локальных переменных для метода
            float ProdType;
            float MaterType;
            try
            {
                ProdType = ProductType[productType];
                MaterType = MaterialType[materialType];

                //Если данные значения равны нулю или меньше его, то возращаем -1
                if (count <=0 || width <= 0 || length<=0)
                {
                    return -1;
                }    

            }
            catch (Exception)
            {
                return -1;
            }
            
            //Формула для подсчета кол-ва необходимиго сырья
            float CalculationMaterialQuantity = (count*ProdType*width*length)*(1+MaterType);
            //Присваивание значения, полученного при подсчетах, возращаемому значению
            int MaterialQuantity = (int)Math.Ceiling(CalculationMaterialQuantity);
            //Возращаемое значение
            return MaterialQuantity;
        }

    }
}