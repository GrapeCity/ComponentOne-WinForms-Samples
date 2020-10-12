using AmazonProductsService;
using C1.CollectionView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonProducts
{
    public class AmazonProductsCollectionView : C1CursorCollectionView<AmazonProductsService.Item, int>, ISupportFiltering
    {
        private string _accessKeyId;
        private string _secretKey;
        private string _associateTag;
        private string _keywords;
        private string _searchIndex;

        public AmazonProductsCollectionView(string accessKeyId, string secretKey, string associateTag)
        {
            _accessKeyId = accessKeyId;
            _secretKey = secretKey;
            _associateTag = associateTag;
        }

        /// <summary>
        /// Response groups help filter the product information you want returned. Each operation can only use some of the available response groups. Each section includes the following: 
        /// <list type="bullet">
        /// <item>Description of the response group.</item>
        /// <item>Descriptions of the XML elements returned by the response group.</item>
        /// <item>The ancestry of the element presented using X-path notation.</item>
        /// <item>Child response groups. For example, if you specify the Large response group, the response includes the child response group, ItemAttributes.</item>
        /// <item>Parent response groups.For example, the Large response group is a parent of the ItemAttributes response group.</item>
        /// </list>
        /// </summary>
        /// <seealso cref="https://docs.aws.amazon.com/AWSECommerceService/latest/DG/CHAP_ResponseGroupsList.html"/>
        public string[] ResponseGroups { get; set; } = new string[] { "Small" };

        protected override async Task<Tuple<int, IReadOnlyList<Item>>> GetPageAsync(int startingIndex, int pageToken, int? count = null, IReadOnlyList<SortDescription> sortDescriptions = null, FilterExpression filterExpression = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(_keywords))
                return new Tuple<int, IReadOnlyList<Item>>(0, new List<Item>());

            var client = new AWSECommerceServicePortTypeClient(new BasicHttpBinding(BasicHttpSecurityMode.Transport) { MaxReceivedMessageSize = int.MaxValue }, new EndpointAddress("https://webservices.amazon.com/onca/soap?Service=AWSECommerceService"));
            client.ChannelFactory.Endpoint.EndpointBehaviors.Add(new AmazonSigningEndpointBehavior(_accessKeyId, _secretKey));

            // prepare an ItemSearch request
            var request = new ItemSearchRequest();
            request.Keywords = _keywords;
            request.SearchIndex = _searchIndex;
            request.ResponseGroup = ResponseGroups;
            request.ItemPage = pageToken == 0 ? null : pageToken.ToString();

            if (filterExpression != null)
                SetFilters(request, filterExpression);

            var itemSearch = new ItemSearch();
            itemSearch.Request = new ItemSearchRequest[] { request };
            itemSearch.AWSAccessKeyId = _accessKeyId;
            itemSearch.AssociateTag = _associateTag;

            // issue the ItemSearch request
            var response = await client.ItemSearchAsync(itemSearch);

            return new Tuple<int, IReadOnlyList<Item>>(pageToken + 1, response.ItemSearchResponse.Items[0].Item);
        }

        public override bool CanFilter(FilterExpression filterExpression)
        {
            var brandExpressions = GetFilterExpressions(filterExpression).OfType<FilterUnaryExpression>().Where(fe => fe.FilterPath == "Brand");
            if (brandExpressions.Count() > 1)
                return false;//Only one brand expression is accepted
            return false;
        }

        private void SetFilters(ItemSearchRequest request, FilterExpression filterExpression)
        {
            var brandExpression = GetFilterExpressions(filterExpression).OfType<FilterUnaryExpression>().FirstOrDefault(fe => fe.FilterPath == "Brand");
            if (brandExpression != null)
            {
                request.Brand = brandExpression.Value?.ToString() ?? "";
            }
        }

        private IEnumerable<FilterExpression> GetFilterExpressions(FilterExpression filterExpression)
        {
            var be = filterExpression as FilterBinaryExpression;
            if (be != null)
            {
                foreach (var exp in GetFilterExpressions(be.LeftExpression))
                {
                    yield return exp;
                }
                foreach (var exp in GetFilterExpressions(be.RightExpression))
                {
                    yield return exp;
                }
            }
            else
            {
                yield return filterExpression;
            }
        }
        /// <summary>
        /// Searches the amazon products.
        /// </summary>
        /// <param name="keywords">The text to search for.</param>
        /// <param name="searchIndex">Some search operations require a search index. Specifying a browse node with a search index returns targeted search results. https://docs.aws.amazon.com/AWSECommerceService/latest/DG/LocaleUS.html</param>
        /// <returns></returns>
        public async Task SearchAsync(string keywords, string searchIndex = "All")
        {
            _keywords = keywords;
            _searchIndex = searchIndex;
            await RefreshAsync();
        }
    }
}
