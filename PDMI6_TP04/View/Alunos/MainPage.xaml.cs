using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDMI6_TP04.AlunosViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMI6_TP04.View.Alunos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        AlunoViewModel vmAluno;
        public MainPage()
        {
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnAlunoTapped(object sender,
        ItemTappedEventArgs args)
        {
            var selecionado = args.Item as PDMI6_TP04.Model.Aluno;
            DisplayAlert("Aluno selecionado", "Aluno: " + selecionado.Id, "OK");
        }
    }
}