namespace Labo1;

public class Counter
{
    // atributos
    private int numCount; // contador de numeros
    private char minusCount; // contador de minusculas
    private char capitalCount; //contador de mayusculas
    
    private Boolean stopMinus = false; // bandera para detener el contador de minusculas
    private Boolean stopNum = false; // bandera para detener el contador de numeros
    
    // constructor
    public Counter()
    {
        numCount = 0;
        minusCount = 'a';
        capitalCount = 'A';
    }
    
    // metodos
    // getters y setters---------------------------------
    public int getNumCount()
    {
        return numCount;
    }
    
    public char getMinusCount()
    {
        return minusCount;
    }
    
    public char getCapitalCount()
    {
        return capitalCount;
    }
    
    public Boolean getStopMinus()
    {
        return stopMinus;
    }
    
    public Boolean getStopNum()
    {
        return stopNum;
    }
    // -----------------------------------------------------------------------------
    public void setNumCount(int numCount)
    {
        this.numCount = numCount;
    }
    
    public void setMinusCount(char minusCount)
    {
        this.minusCount = minusCount;
    }
    
    public void setCapitalCount(char capitalCount)
    {
        this.capitalCount = capitalCount;
    }
    // ----------------------------------------------------------------------------------
    public void incrementNumCount()
    {
        numCount++;
        evaluateNumCount(); // evalua el contador de numeros
        Thread.Sleep(100);
    }
    
    public void incrementMinusCount()
    {
        minusCount++;
        Thread.Sleep(200);
    }
    
    public void incrementCapitalCount()
    {
        capitalCount++;
        Thread.Sleep(150);
    }
    
    // metodo para evaluar el contador de numeros--------------------------------------
    public void evaluateNumCount()
    {
        if(numCount == 20)
        {
            // si el numero es igual a 20, detiene el contador de minusculas
            stopMinus = true;
            stopNum = true;
            
            Console.WriteLine("Se ha llegado al limite de numeros");
        }
    }
}