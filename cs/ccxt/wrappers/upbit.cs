namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class upbit
{
    public async Task<Dictionary<string, object>> FetchCurrency(string code, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchCurrency(code, parameters);
        return ((Dictionary<string, object>)res);
    }
    public async Task<Dictionary<string, object>> FetchCurrencyById(string id, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchCurrencyById(id, parameters);
        return ((Dictionary<string, object>)res);
    }
    public async Task<MarketInterface> FetchMarket(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarket(symbol, parameters);
        return new MarketInterface(res);
    }
    public async Task<MarketInterface> FetchMarketById(string id, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarketById(id, parameters);
        return new MarketInterface(res);
    }
    /// <summary>
    /// retrieves data on all markets for upbit
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/마켓-코드-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/listing-market-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> an array of objects representing market data.</returns>
    public async Task<List<MarketInterface>> FetchMarkets(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarkets(parameters);
        return ((IList<object>)res).Select(item => new MarketInterface(item)).ToList<MarketInterface>();
    }
    /// <summary>
    /// query for balance and get the amount of funds available for trading or funds locked in orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/전체-계좌-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/overall-account-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}.</returns>
    public async Task<Balances> FetchBalance(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchBalance(parameters);
        return new Balances(res);
    }
    /// <summary>
    /// fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data for multiple markets
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/호가-정보-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/order-book-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : not used by upbit fetchOrderBooks ()
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbol.</returns>
    public async Task<OrderBooks> FetchOrderBooks(List<String> symbols = null, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrderBooks(symbols, limit, parameters);
        return new OrderBooks(res);
    }
    /// <summary>
    /// fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/호가-정보-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/order-book-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of order book entries to return
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols.</returns>
    public async Task<OrderBook> FetchOrderBook(string symbol, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrderBook(symbol, limit, parameters);
        return new OrderBook(res);
    }
    /// <summary>
    /// fetches price tickers for multiple markets, statistical information calculated over the past 24 hours for each market
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/ticker현재가-정보"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/tickers"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Tickers> FetchTickers(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTickers(symbols, parameters);
        return new Tickers(res);
    }
    /// <summary>
    /// fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/ticker현재가-정보"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/tickers"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Ticker> FetchTicker(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTicker(symbol, parameters);
        return new Ticker(res);
    }
    /// <summary>
    /// get the list of most recent trades for a particular symbol
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/최근-체결-내역"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/today-trades-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest trade to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of trades to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}.</returns>
    public async Task<List<Trade>> FetchTrades(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetch the trading fees for a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/주문-가능-정보"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/available-order-information"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [fee structure]{@link https://docs.ccxt.com/#/?id=fee-structure}.</returns>
    public async Task<TradingFeeInterface> FetchTradingFee(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTradingFee(symbol, parameters);
        return new TradingFeeInterface(res);
    }
    /// <summary>
    /// fetch the trading fees for markets
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [trading fee structure]{@link https://docs.ccxt.com/#/?id=trading-fee-structure}.</returns>
    public async Task<TradingFees> FetchTradingFees(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTradingFees(parameters);
        return new TradingFees(res);
    }
    /// <summary>
    /// fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/분minute-캔들-1"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/minutes"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest candle to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of candles to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int[][]</term> A list of candles ordered as timestamp, open, high, low, close, volume.</returns>
    public async Task<List<OHLCV>> FetchOHLCV(string symbol, string timeframe = "1m", Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOHLCV(symbol, timeframe, since, limit, parameters);
        return ((IList<object>)res).Select(item => new OHLCV(item)).ToList<OHLCV>();
    }
    /// <summary>
    /// create a trade order
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/주문하기"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>price</term>
    /// <description>
    /// float : the price at which the order is to be fulfilled, in units of the quote currency, ignored in market orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.cost</term>
    /// <description>
    /// float : for market buy and best buy orders, the quote quantity that can be used as an alternative for the amount
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.ordType</term>
    /// <description>
    /// string : this field can be used to place a ‘best’ type order
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.timeInForce</term>
    /// <description>
    /// string : 'IOC' or 'FOK'. only for limit or best type orders. this field is required when the order type is 'best'.
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CreateOrder(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.createOrder(symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    /// <summary>
    /// cancels an open order
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/주문-취소"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/order-cancel"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CancelOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelOrder(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// canceled existing order and create new order. It's only generated same side and symbol as the canceled order. it returns the data of the canceled order, except for `new_order_uuid` and `new_identifier`. to get the details of the new order, use `fetchOrder(new_order_uuid)`.
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/취소-후-재주문"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/cancel-and-new"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.clientOrderId</term>
    /// <description>
    /// string : to identify the previous order, either the id or this field is required in this method.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.cost</term>
    /// <description>
    /// float : for market buy and best buy orders, the quote quantity that can be used as an alternative for the amount.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.newTimeInForce</term>
    /// <description>
    /// string : 'IOC' or 'FOK'. only for limit or best type orders. this field is required when the order type is 'best'.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.newClientOrderId</term>
    /// <description>
    /// string : the order ID that the user can define.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.newOrdType</term>
    /// <description>
    /// string : this field only accepts limit, price, market, or best. You can refer to the Upbit developer documentation for details on how to use this field.
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> EditOrder(string id, string symbol, string type, string side, double? amount2 = 0, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var amount = amount2 == 0 ? null : (object)amount2;
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.editOrder(id, symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    /// <summary>
    /// fetch all deposits made to an account
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/입금-리스트-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/deposit-list-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch deposits for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of deposits structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchDeposits(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchDeposits(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// fetch information on a deposit
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/개별-입금-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/individual-deposit-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>code</term>
    /// <description>
    /// string : unified currency code of the currency deposited
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.txid</term>
    /// <description>
    /// string : withdrawal transaction id, the id argument is reserved for uuid
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<Transaction> FetchDeposit(string id, string code = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchDeposit(id, code, parameters);
        return new Transaction(res);
    }
    /// <summary>
    /// fetch all withdrawals made from an account
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/전체-출금-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/withdrawal-list-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch withdrawals for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of withdrawals structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchWithdrawals(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchWithdrawals(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// fetch data on a currency withdrawal via the withdrawal id
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/개별-출금-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/individual-withdrawal-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>code</term>
    /// <description>
    /// string : unified currency code of the currency withdrawn
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.txid</term>
    /// <description>
    /// string : withdrawal transaction id, the id argument is reserved for uuid
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<Transaction> FetchWithdrawal(string id, string code = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchWithdrawal(id, code, parameters);
        return new Transaction(res);
    }
    /// <summary>
    /// fetch all unfilled currently open orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/대기-주문-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/open-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch open orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of open order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.state</term>
    /// <description>
    /// string : default is 'wait', set to 'watch' for stop limit orders
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchOpenOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOpenOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on multiple closed orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/종료-주문-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/closed-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.until</term>
    /// <description>
    /// int : timestamp in ms of the latest order
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchClosedOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchClosedOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on multiple canceled orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/종료-주문-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/closed-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest order, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : max number of orders to return, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.until</term>
    /// <description>
    /// int : timestamp in ms of the latest order
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchCanceledOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchCanceledOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on an order made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/개별-주문-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/individual-order-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> FetchOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchOrder(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// fetch deposit addresses for multiple currencies and chain types
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/전체-입금-주소-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/general-deposit-address-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a list of [address structures]{@link https://docs.ccxt.com/#/?id=address-structure}.</returns>
    public async Task<List<DepositAddress>> FetchDepositAddresses(List<String> codes = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchDepositAddresses(codes, parameters);
        return ((IList<object>)res).Select(item => new DepositAddress(item)).ToList<DepositAddress>();
    }
    /// <summary>
    /// fetch the deposit address for a currency associated with this account
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/개별-입금-주소-조회"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/individual-deposit-address-inquiry"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}.</returns>
    public async Task<DepositAddress> FetchDepositAddress(string code, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchDepositAddress(code, parameters);
        return new DepositAddress(res);
    }
    /// <summary>
    /// create a currency deposit address
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/입금-주소-생성-요청"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/deposit-address-generation"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}.</returns>
    public async Task<DepositAddress> CreateDepositAddress(string code, Dictionary<string, object> parameters = null)
    {
        var res = await this.createDepositAddress(code, parameters);
        return new DepositAddress(res);
    }
    /// <summary>
    /// make a withdrawal
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.upbit.com/kr/reference/디지털자산-출금하기"/>  <br/>
    /// See <see href="https://global-docs.upbit.com/reference/withdrawal-digital-assets"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<Transaction> Withdraw(string code, double amount, string address, object tag = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.withdraw(code, amount, address, tag, parameters);
        return new Transaction(res);
    }
}
