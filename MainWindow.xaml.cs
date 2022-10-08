using ArthurCrivilinDelCaro_d7_avaliacao.Data;
using System.Linq;
using System.Windows;

namespace ArthurCrivilinDelCaro_d7_avaliacao;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly Context context;

    public MainWindow(Context context)
    {
        this.context = context;
        InitializeComponent();
    }

    private bool CheckUserLogin(string user, string pass)
    {
        User? userList = context.Users?.Where(x => user == x.Email).Where(x => pass == x.Password).FirstOrDefault();
        return userList == null;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var email = UserEmail.Text;
        var pass = UserPassword.Password;
        if (email == null || pass == null || email.Trim() == "" || pass.Trim() == "")
        {
            MessageBox.Show("Campo(s) em branco!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        else
        {
            if (CheckUserLogin(email, pass))
            {
                MessageBox.Show("Credenciais inválidas", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Usuário autenticado!", "Autenticado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}

