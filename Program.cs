namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        //Atama ve işlemli atama
        Console.WriteLine("Atama ve işlemli atama");

        int x=3,y=3;
        
        Console.WriteLine("x="+  x );
        x+=2;
        Console.WriteLine("x+=2---"+  x );
        
        Console.WriteLine("y="+ y);
        y*=2;
        Console.WriteLine("y*=2----"+ y);

        y/=1;
        Console.WriteLine("\n"+ "y/=1---"+ y);


        //mantıksal operatorler
        // || &&
        Console.WriteLine("mantıksal operatorler");

        bool isSucces=true;
        bool isCompleted=false;

        

        if(isSucces&&isCompleted){
            Console.WriteLine("Perfect");  
        }
        if(isSucces||isCompleted){
            Console.WriteLine("Great");
        }
        if(isSucces&&!isCompleted){
            Console.WriteLine("Fine");
        }

        //İlişkisel operatorler
        //<, >,  >=, <=, !=

        Console.WriteLine("İlişkisel operatorler");
        int a=5,b=10;
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);

        bool sonuc=a<b;

        if(sonuc) {
           Console.WriteLine(a+"<"+b); 
        }else{
            Console.WriteLine(a+">"+b); 
        }
        

        
        



    }
}
 