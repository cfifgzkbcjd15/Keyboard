$("body").prepend('<img id="loaderPage" src="../style/ponasenkov.gif" alt="">');
let baseURL = "https://localhost:44358";

let json = {
    "id": "4055116",
    "publishDate": "2014-01-13T17:48:04Z",
    "signDate": "2013-12-31",
    "customer": {
      "regNum": "03153000009",
      "fullName": "Муниципальное казённое учреждение \"Земельное управление\" муниципального образования города Чебоксары - столицы Чувашской Республики",
      "inn": "2127026941",
      "kpp": "213001001"
    },
    "protocolDate": "",
    "documentBase": "",
    "price": 12109.74,
    "singleCustomerReason": {
      "name": "Пункт 1 части 2 статьи 55 – Поставки товаров, выполнение работ, оказание услуг относятся к сфере деятельности субъектов естественных монополий"
    },
    "products": {
      "product": [
        {
          "sid": "50510868",
          "OKPD": {
            "code": "41.00.20.120",
            "name": ""
          },
          "name": "Отпуск холодной питьевой воды и прием сточных вод",
          "OKEI": {
            "code": "876",
            "nationalCode": "УСЛ ЕД"
          },
          "price": 12109.74,
          "quantity": 1,
          "sum": 12109.74
        }
      ]
    },
    "suppliers": {
      "supplier": [
        {
          "participantType": "U",
          "inn": "2130017760",
          "kpp": "213001001",
          "organizationName": "\"Водоканал\"",
          "country": {
            "countryCode": "643",
            "countryFullName": "Российская Федерация"
          },
          "factualAddress": "428024 г.Чебоксары, Мясокомбинатский проезд, 12",
          "postAddress": "428024 г.Чебоксары, Мясокомбинатский проезд, 12",
          "contactInfo": {
            "lastName": "",
            "firstName": "",
            "middleName": ""
          },
          "contactEMail": "",
          "contactPhone": "8-8352-516539",
          "contactFax": ""
        }
      ]
    },
    "href": "http://zakupki.gov.ru/pgz/public/action/contracts/info/common_info/show?contractInfoId=4055116"
  };

$(function() 
{
    $("#sendContract").click(function(){
    let data = new Date($("#to").val())

        let [from, to, prodyct, customer, legalForma, minSumm, maxSumm] = [$("#from").val(), $("#to").val(), $("#prodyct").val(),
            $("#customer").val(), $("#legalForma").val(), $("#minSumm").val(), $("#maxSumm").val()];
        


        let jsonContract = `
                {
                  "minPrice": "${minSumm}",
                  "maxPrice": "${maxSumm}",
                  "startDate": "${from}",
                  "endDate": "${to}",
                  "productName": "${prodyct == null ? '" "' : prodyct}",
                  "fullNameCustomer": "${customer==null?'" "':customer}",
                  "page": 0
                }`;

        $.ajax({
            url: 'https://localhost:44358/api/Contract/withContract',
            method: 'post',
            contentType:'application/json',
            dataType: 'json',
            data: jsonContract,
            success: function(data)
            {
                $("#listValue").empty()
                for (let x in data)
                {
                    $("#listValue").append(
                    `
                        <li class="list-group-item border border-top-0 border-start-0 border-end-0 rounded-0 border-dark" style="background: #F2F2F2;">
                        <div class="row mb-2">
                            <div class="col-sm-9">
                                <p class="text-muted m-0">Название</p>
                                <p class="text m-0">${data[x].customer.fullName}</p>
                            </div>
                            <div class="col-sm-3">
                                <p class="text-muted m-0">Дата</p>
                                <p class="text m-0">${"От " + data[x].signDate.replace(/[^\-/:0-9]/g," ")} <br/>${"По " + data[x].publishDate.replace(/[^\-/:0-9]/g," ")}</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="text-muted m-0">Цена</p>
                                <p class="text m-0">${data[x].price} ру</p>
                            </div>
                            <div class="col-sm-6"></div>
                            <div class="col-sm-3">
                                <button id="${data[x].id}" onClick="renderModalValue(this.id)" class="btn active rounded-0 btnHover" data-bs-toggle="modal" data-bs-target="#modalValue" >Просмотр</button>
                            </div>
                        </div>
                    </li>
                    `);
                };
            },
            error: function (jqXHR, exception) 
            {
                logErrorAjax(jqXHR, exception)
            }
        });
    });
    
    

    async function logErrorAjax(jqXHR, exception)
    {
        if (jqXHR.status === 0) {
            console.log('Not connect. Verify Network.');
        } else if (jqXHR.status == 404) {
            console.log('Requested page not found (404).');
        } else if (jqXHR.status == 500) {
            console.log('Internal Server Error (500).');
        } else if (exception === 'parsererror') {
            console.log('Requested JSON parse failed.');
        } else if (exception === 'timeout') {
            console.log('Time out error.');
        } else if (exception === 'abort') {
            console.log('Ajax request aborted.');
        } else {
            console.log('Uncaught Error. ' + jqXHR.responseText);
        }
    };

    setTimeout(function () 
    {
        $("#loaderPage").remove();
    }, 100);
    
});

function renderModalValue(id)
    {



        $.ajax({
            url: `https://localhost:44358/api/Contract/${id}` ,
            method: 'get',
            contentType:'application/json',
            dataType: 'json',
            success: function(data)
            {
                $("#divModalValue").empty();
                
                    $("#divModalValue").append(
                    `
                        <div class="row">
                            <div class="col-sm-4">
                                <p class="text">Ид</p>
                                <p class="text-muted">${data.id}</p>
                            </div>
                            <div class="col-sm-4"><p class="text">Ссылка</p><p class="text-muted">${data.href}</p></div>
                            <div class="col-sm-4"><p class="text">Цена</p><p class="text-muted">${data.price}</p></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3"><p class="text">Регестрационый номер</p><p class="text-muted">${data.customer.regNum}</p></div>
                            <div class="col-sm-3"><p class="text">Имя</p><p class="text-muted">${data.customer.fullName}</p></div>
                            <div class="col-sm-3"><p class="text">ИНН</p><p class="text-muted">${data.customer.inn}</p></div>
                            <div class="col-sm-3"><p class="text">КПП</p><p class="text-muted">${data.customer.kpp}</p></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-2"><p class="text">СИД</p><p class="text-muted">${data.products.sid}</p></div>
                            <div class="col-sm-2"><p class="text">Имя</p><p class="text-muted">${data.products.name}</p></div>
                            <div class="col-sm-2"><p class="text">Цена</p><p class="text-muted">${data.products.price}</p></div>
                            <div class="col-sm-2"><p class="text">Количество</p><p class="text-muted">${data.products.quantity}</p></div>
                            <div class="col-sm-2"><p class="text">Цена</p><p class="text-muted">${data.products.sum}</p></div>
                        </div>
                        
                    `);
                

            },
            error: function (jqXHR, exception) 
            {
                logErrorAjax(jqXHR, exception)
            }
        });

    }