using Uygulama_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Nokia nokia1 = new Nokia();
        Nokia nokia2 = new Nokia();

        Iphone iphone1 = new Iphone();
        Iphone iphone2 = new Iphone();
        Iphone iphone3 = new Iphone();

        Samsung samsung1 = new Samsung();
        Samsung samsung2 = new Samsung();

        List<BasePhone> phones = new List<BasePhone>() { nokia1, nokia2, iphone1, iphone2, iphone3, samsung1, samsung2 };
        foreach (var phone in phones)
        {
            phone.Call();

            //if(phone.GetType()==typeof(Nokia))
            //{
            //    Nokia nokia= (Nokia)phone;
            //    nokia.CallSound();
            //}
            //else if(phone.GetType()==typeof(Iphone))
            //{
            //    Iphone ıphone= (Iphone)phone;
            //    ıphone.CallSound();
            //}
            //else if(phone.GetType()==typeof(Samsung))
            //{
            //    Samsung samsung= (Samsung)phone;
            //    samsung.CallSound();
            //}
        }
    }
}