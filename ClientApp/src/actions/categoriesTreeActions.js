import axios from 'axios';
import { RECEIVE_CATEGORIES_TREE } from '../reducers/categoriesReducer';
import { RECEIVE_CATEGORY_TREE } from '../reducers/categoriesReducer';

export function getCategoriesTreeFromRoot() {
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

export function getCategoryTree(categoryUrl) {
  return function (dispatch) {
    return axios.get(`/api/categories/tree/url/${categoryUrl}`)
      .then(response => {
        dispatch({
          type: RECEIVE_CATEGORY_TREE,
          data: response.data,
          receivedAt: Date.now()
        })
      });
  }
}
