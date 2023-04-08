
const apiKey = process.env['DAPPRADARAPIKEY']
const options = {
    method: 'GET',
    headers: {
        'X-BLOBR-KEY': apiKey
    },
};

// fetch api available in node 18+
fetch('https://api.dappradar.com/4tsxo4vuhotaojtl/dapps?resultsPerPage=10', options)
    .then(response => response.json())
    .then(response => console.log(response))
    .catch(err => console.error(err));