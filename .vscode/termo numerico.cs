namespace termo;
public class tela()
{
    public int bloco1 = 0;  
    
    public int bloco2 = 0;  
    
    public int bloco3 = 0;  
    
    public int bloco4 = 0;  
    
    public int bloco5 = 0;  
    public void sorteio(object sender, EventArgs e)
    {
        private int rand;
        for(i = 0; i ==5; i++){
            Random rand = new Random();
            switch(i)
            {
                case 1:
                i==0;
                bloco1= rand;
                break;

                 case 2:
                i==0;
                bloco2= rand;
                break;

                 case 3:
                i==0;
                bloco3= rand;
                    break;  

                 case 4:
                i==0;
                bloco4= rand;
                break;

                 case 5:
                i==0;
                bloco5= rand;
                break;

            }
            Console.WriteLine($"bloco1 ={bloco1}");
            Console.WriteLine($"bloco2 ={bloco2}");
            Console.WriteLine($"bloco3 ={bloco3}");
            Console.WriteLine($"bloco4 ={bloco4}");
            Console.WriteLine($"bloco5 ={bloco5}");
        }
        

    }











}