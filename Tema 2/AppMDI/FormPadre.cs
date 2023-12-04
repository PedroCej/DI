namespace AppMDI
{
    public partial class FormPadre : Form
    {
        private FormHijo1 nuevoFormularioHijo;
        List<FormHijo1> listaFormulariosHijo = new List<FormHijo1>();
        public FormPadre()
        {
            InitializeComponent();
        }

        private void MenuItem_Nuevo_Click(object sender, EventArgs e)
        {


            if (listaFormulariosHijo.Count == 0)
            {
                nuevoFormularioHijo = new FormHijo1("");
            }
            else
            {
                nuevoFormularioHijo = new FormHijo1(listaFormulariosHijo[listaFormulariosHijo.Count - 1].get_TxtBox());
            }

            nuevoFormularioHijo.MdiParent = this;
            nuevoFormularioHijo.Show();
            listaFormulariosHijo.Add(nuevoFormularioHijo);

            //this.Text = this.MdiChildren.Count().ToString();
            //Se utiliza  this.MdiChildren.Count()  para saber cuantos hijos tiene el padre (this)
        }

        public void EliminarDeLaLista(FormHijo1 formHijo1)
        {
            listaFormulariosHijo.Remove(formHijo1);

        }

    }
}