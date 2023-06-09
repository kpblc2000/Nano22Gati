using Nano22GatiCore.Infrastructure;
using Nano22GatiCore.Infrastructure.Commands;
using Nano22GatiCore.Interfaces;
using Nano22GatiCore.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Nano22GatiCore.ViewModels
{
    public partial class GatiWindowViewModel : ViewModel
    {
        public GatiWindowViewModel(INCadRepository Cadrepository, IMessageService MessageService)
        {
            Title = "Протокол мобильного обмена для ГИС";
            _cadRepository = Cadrepository;
            _messageService = MessageService;
            LayerNamesList = _cadRepository.GetLayerNamesList();

            PrecisionsList = new List<Precision>()
            {
                new Precision("Авто", 0, true),
                new Precision("0", 0),
                new Precision("1", 1),
                new Precision("2", 2),
            };

            CopyLayerNameToPassportCommand = new RelayCommand(OnCopyLayerNameToPassportCommandExecuted, CanCopyLayerNameToPassportCommandExecute);
        }

        /// <summary>
        /// Список слоев текущего документа, не включенных в паспорт
        /// </summary>
        public List<string> LayerNamesList
        {
            get => _layerNamesList;
            private set => Set(ref _layerNamesList, value);
        }

        /// <summary>
        /// Выбранный слой из чертежа.
        /// </summary>
        public string SelectedDrawingLayerName
        {
            get => _selectedDrawingLayerName;
            set => Set(ref _selectedDrawingLayerName, value);
        }

        /// <summary>
        /// Список слоев, включенных в паспорт
        /// </summary>
        public List<LayerToPassport> LayerNamesToPassportList
        {
            get => _layerNamesToPassportList;
            set => Set(ref _layerNamesToPassportList, value);
        }

        public LayerToPassport SelectedPassportName
        {
            get => _selectedPassportLayerName;
            set => Set(ref _selectedPassportLayerName, value);
        }

        /// <summary>
        /// Список "точностей"
        /// </summary>
        public List<Precision> PrecisionsList
        {
            get => _precisionsList;
            private set => Set(ref _precisionsList, value);
        }

        public Precision SelectedPrecision
        {
            get => _selectedPrecision;
            set => Set(ref _selectedPrecision, value);
        }

        /// <summary>
        /// Заголовок паспорта объекта
        /// </summary>
        public string PassportName
        {
            get => _passportName;
            set => Set(ref _passportName, value);
        }

        private List<string> _layerNamesList;
        private List<LayerToPassport> _layerNamesToPassportList;
        private INCadRepository _cadRepository;
        private IMessageService _messageService;
        private List<Precision> _precisionsList;
        private Precision _selectedPrecision;
        private string _selectedDrawingLayerName;
        private LayerToPassport _selectedPassportLayerName;
        private string _passportName;
    }
}
