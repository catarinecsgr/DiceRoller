namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }



    protected class Dado
    {

        private int NumerodeLados; //Atriburo

        public Dado() //Construtor
        { }

        public Dado(int numerodeLados) //Método - esse possui um parâmetro (é a chamada "assinatura do método")
        {
            NumerodeLados = numerodeLados; //o número de lados é o parâmetro da assinatura do método
        }


        public int RollDice() //gerando um número aleatório
        {
            int random = new Random().Next(1, NumerodeLados + 1); ; //"new" é uma NOVA INSTÂNCIA
            return random;

            //return new Random().Next(1, NumerodeLados + 1); //outra forma de fazer
        }


    }
    /*public void OnRollClicked(object sender, EventArgs e)
    {
    
    int SeletorDosLados = (int)SeletorDosLados.SelectedItem; //Ler o número que o usuário selecionou no Picker
    Dado dado = new Dado(SeletorDosLados); //Instancia um novo dado com N lados, onde N é o número selecionado
    dado.RollDice(); //Chamar o método para sortear o número
    numberOutput.Text = numero.ToString();//Mostrar o número num label

    }*/

    private void OnButtonClicked(object sender, EventArgs e)
    {

        int NumerodeLados = (Int32)SeletorDosLados.SelectedItem; //Ler o número que o usuário selecionou no Picker
        Dado dado = new Dado(NumerodeLados); //Instancia um novo dado com N lados, onde N é o número selecionado
        numberOutput.Text = dado.RollDice().ToString(); //Mostrar o número num label







        /*int min = 1;
        var numeroSelecionado = picker.SelectedItem;
        
        int max = int.Parse(numeroSelecionado.ToString()) + 1;

        Random random = new Random();

        int numeroGerado = random.Next(min, max);
        numberOutput.Text = numeroGerado.ToString();*/

        /*código referencia para adicionar tema
          
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if(currentTheme.ToString() != "Unspecified")
        { 
            diceImage.Source = ImageSource.FromFile($"{currentTheme}_dice_d{NumerodeLados}.png"); 
        }
        else
        {
            diceImage.Source = ImageSource.FromFile($"dice_d{NumerodeLados}.png");
        }*/


    }

    public void OnChangedOption(object sender, EventArgs e)
    {
        int NumerodeLados = (int)SeletorDosLados.SelectedItem;
        Image image = new Image { Source = $"dice_d (NumerodeLados).png" };
        diceImage.Source = Image.Source;
    }


}
