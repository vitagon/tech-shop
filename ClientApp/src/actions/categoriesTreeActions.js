import axios from 'axios';
import { RECEIVE_CATEGORIES_TREE } from '../reducers/categoriesReducer';

export function getCategoriesTree() {
  return function (dispatch) {
    return axios.get('/api/categories/tree')
      .then(response => {
        dispatch({
          type: RECEIVE_CATEGORIES_TREE,
          data: response.data,
          receivedAt: Date.now()
        })
      });
  }
}
