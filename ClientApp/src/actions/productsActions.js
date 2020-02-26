import _ from 'lodash';
import axios from 'axios';
import { RECEIVE_PRODUCTS } from './../reducers/productsReducer';

export function getProducts(filters) {
  return function (dispatch) {
    let urlParams = '',
      url = '/api/products';

    console.log(filters);
    if (filters != null) {
      urlParams = new URLSearchParams(filters).toString();
      url = url + '?' + urlParams;
    }
    
    return axios.get(url)
      .then(response => {
        let metadata = JSON.parse(response.headers['x-pagination']);
        dispatch({
          type: RECEIVE_PRODUCTS,
          data: response.data,
          metadata: metadata,
          receivedAt: Date.now()
        })
      });
  }
}