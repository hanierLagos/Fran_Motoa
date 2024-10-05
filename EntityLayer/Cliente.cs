namespace EntityLayer
{
    public class Cliente
    {
        public int ID_CLIENTE {  get; set; }
        public string CODIGO_CLIENTE { get; set; }

        public string NOMBRES {  get; set; }
        public string APELLIDOS { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string Codigo { get; }

       
        public Cliente(string codigo, string nombres, string apellidos, string telefono, string direccion)
        {
            CODIGO_CLIENTE = codigo;
            NOMBRES = nombres;
            APELLIDOS = apellidos;
            TELEFONO = telefono;
            DIRECCION = direccion;
        }
    }
}
