using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viagem.Models;

namespace Viagem.ViewModel
{
    public partial class ViagemViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<ViagemItem> _viagens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Viagens.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;

        public ViagemViewModel()
        {
           Viagens = new List<ViagemItem>   
            {
                new ViagemItem
                {
                    Titulo = "Explore \r\nExotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide.",
                    ImageUrl = "primeira.png"
                },
                new ViagemItem
                {
                    Titulo = "Discover \r\nLocal Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                    ImageUrl = "segunda.png"
                },
                new ViagemItem
                {
                    Titulo = "Plan \r\nYour Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                    ImageUrl = "terceira.png"
                }, 
                new ViagemItem
                {
                    Titulo = "Capture and Share Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                    ImageUrl = "ultima.png"
                }
            };
        }

        [RelayCommand]
        private void Proximo()
        {
            if (Posicao < Viagens.Count - 1)
            {
                Posicao++;
            }
        }
    }
}
