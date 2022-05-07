try
{
    Login("doejhon","123456789");
    Console.WriteLine("Login Basarili");
}
catch (LoginException ex)
{
    Console.WriteLine(ex.Message);
}

static void Login(string userName, string pass)
{
    if(userName.Contains(" "))
        throw new LoginException("Username bosluk iceremez.");
    
    if(pass.Length<8)
        throw new LoginException("Parola 8 karakterden kucuk olamaz");
}

class LoginException : Exception // Gercek uygulamalarda bu tarz hata siniflari olusturulup, hata yonetimi yapilir.
{
    public LoginException(string message): base(message)
    {
        
    }

}