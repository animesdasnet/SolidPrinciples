using ISP;

public class main {
    public static void Main(string[] args)
    {
        //single responsibility prinicple

        InternetServiceProvider internetServiceprovider = new InternetServiceProvider();
        internetServiceprovider.InternetSubscriberId(1);
        internetServiceprovider.InternetSubscriberName("Animesh");
        NetworkSpeed netSpeed = new NetworkSpeed();
        netSpeed.InternetSpeed(20);


        //open closed principle

        BlockedUrl blockedURL = new BlockedUrl();
        blockedURL.WebsiteName();


        //liskov substitution principle

        IncreasedNetworkBandwidth iNetwork = new IncreasedNetworkBandwidth();
        iNetwork.networkBandwidth(100);
        iNetwork.networkPing();


        //interface segregation principle

        NetworkPing networkPing = new NetworkPing();
        networkPing.InternetNetworkPing();
        NetworkDetails networkDetails = new NetworkDetails();
        networkDetails.NetworkId();
        networkDetails.NetworkName();


        //dependency inversion principle
        //DataRate dataRate = new DataRate(new PacketData());
        //dataRate.PacketDataRate();

    }
}
