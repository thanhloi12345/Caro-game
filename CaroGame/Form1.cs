namespace CaroGame
{
    public partial class caroGame : Form
    {
        public static int ChieuRongBanCo;
        public static int ChieuCaoBanCo;
        private Graphics grp;
        private C_DieuKhien DieuKhien;
        private Color myColor;
        private Form2 LuatChoi;

        public caroGame()
        {
            InitializeComponent();
            grp = panelBanCo.CreateGraphics();
            myColor = panelBanCo.BackColor;
            //lấy chiều rộng và chiều cao pnBanCo để vẽ bàn cờ
            ChieuCaoBanCo = panelBanCo.Height;
            ChieuRongBanCo = panelBanCo.Width;

            //khởi tạo đối tượng điều khiển trò chơi
            DieuKhien = new C_DieuKhien();

            LuatChoi = new Form2();
        }

        private void Ngame_Click(object sender, EventArgs e)
        {

        }

        private void panelBanCo_Paint(object sender, PaintEventArgs e)
        {
            if (DieuKhien.SanSang)
            {
                //vẽ bàn cờ
                DieuKhien.veBanCo(grp);
                //vẽ lại các quân cờ trong stack
                DieuKhien.veLaiQuanCo(grp);
            }
        }

        private void nguoi_Click(object sender, EventArgs e)
        {
            grp.Clear(panelBanCo.BackColor);
            panelBanCo.BackColor = myColor;
            DieuKhien.choiVoiNguoi(grp);

           // grp.Clear(panelBanCo.BackColor);
        }

        private void panelBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (DieuKhien.SanSang)
            {
                //chơi với người
                if (DieuKhien.CheDoChoi == 1)
                {
                    //đánh cờ với tọa độ chuột khi lick vào panel bàn cờ
                    DieuKhien.danhCo(grp, e.Location.X, e.Location.Y);
                    //sau khi đánh cờ thì kiểm tra chiến thắng luôn
                    DieuKhien.kiemTraChienThang(grp);
                }
                //chơi với máy
                else
                {
                    //người chơi đánh
                    DieuKhien.danhCo(grp, e.Location.X, e.Location.Y);
                    //kiểm tra người chơi chưa chiến thắng thì cho máy đánh
                    if (!DieuKhien.kiemTraChienThang(grp))
                    {
                        //máy đánh
                        DieuKhien.mayDanh(grp);
                        DieuKhien.kiemTraChienThang(grp);
                    }
                }
            }
        }

        private void may_Click(object sender, EventArgs e)
        {

            grp.Clear(panelBanCo.BackColor);
            panelBanCo.BackColor = myColor;
            DieuKhien.choiVoiMay(grp);

            //Image image = new Bitmap(Properties.Resources.b);
            //pnlBanCo.BackgroundImage = image;
            //xóa tất cả các hình đã vẽ trên panel chỉ giữ lại màu nền panel
        }

        private void caroGame_Load(object sender, EventArgs e)
        {

        }

        private void luatChoi_Click(object sender, EventArgs e)
        {
            LuatChoi.ShowDialog();
        }

        private void phienban_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Cờ caro \n Phiên bản 1.0 \n Tác giả: Trần Thành Lợi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}