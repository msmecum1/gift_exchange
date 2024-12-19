using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Gift_Exchange.Models;
using Gift_Exchange.Services;
using Microsoft.Maui.Controls;

namespace Gift_Exchange.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Player> Players { get; set; } = new ObservableCollection<Player>();
        public ObservableCollection<GiftExchangePair> Pairs { get; set; } = new ObservableCollection<GiftExchangePair>();

        public ICommand AddPlayerCommand { get; }
        public ICommand GeneratePairsCommand { get; }

        public MainViewModel()
        {
            AddPlayerCommand = new Command(AddPlayer);
            GeneratePairsCommand = new Command(GeneratePairs);
        }

        private void AddPlayer()
        {
            // Example logic to add a player (you can customize as needed)
            var newPlayer = new Player { Name = "New Player", Email = "newplayer@example.com" };
            Players.Add(newPlayer);
            OnPropertyChanged(nameof(Players));
        }

        private void GeneratePairs()
        {
            var service = new ExchangeService();
            var pairs = service.GenerateGiftExchangePairs(Players.ToList());
            Pairs.Clear();
            foreach (var pair in pairs)
            {
                Pairs.Add(pair);
            }
            OnPropertyChanged(nameof(Pairs));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
