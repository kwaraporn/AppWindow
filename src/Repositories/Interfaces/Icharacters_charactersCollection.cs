// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// characters_charactersCollection interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Icharacters_charactersCollection
    {
		ObservableCollection<Entities.charactersSchema> GetData(int pageNumber = 0);
		ObservableCollection<Entities.charactersSchema> Search(FilterSpecification filter);
		bool HasPrevious(Entities.charactersSchema current);
		bool HasNext(Entities.charactersSchema current);
		Entities.charactersSchema Previous(Entities.charactersSchema current);
		Entities.charactersSchema Next(Entities.charactersSchema current);
    }
}