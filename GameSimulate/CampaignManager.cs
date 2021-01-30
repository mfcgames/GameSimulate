using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulate
{
    class CampaignManager : ICampignService
    {
        public void CampaignEnter(Campaigns campaigns,SellProduct sellProduct)
        {
            Console.WriteLine(campaigns.CampignsName + " " + "Kampanyaları Başladı "+sellProduct.ProductName+" "+sellProduct.ProductPrice + " 'dan "+ " % "+campaigns.Sale+" İndirim ile "+" "+campaigns.SaleTime+" gün Boyunca Devam Edecek ");
        }

        public void DeleteCampaign(Campaigns campaigns, SellProduct sellProduct)
        {
            Console.WriteLine(sellProduct.ProductName +" "+ sellProduct.ProductPrice +" 'dan"+" ve"+ " % " + campaigns.Sale + " İndirimi ile " + campaigns.CampignsName + " " + "Kampanya'sı Sona Erdi!");
        }

        public void UpdateCampaign(Campaigns campaigns, SellProduct sellProduct)
        {
            Console.WriteLine(campaigns.CampignsName + " " + "Kampanya'sı Yenilendi " + sellProduct.ProductName +" "+ sellProduct.ProductPrice + " % " + campaigns.Sale + " İndirim ile" +  " " + campaigns.SaleTime+" Güne Kadar Devam Edecek");
        }
    }
}
