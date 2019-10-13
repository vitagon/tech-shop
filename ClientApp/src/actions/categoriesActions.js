import axios from 'axios';

export const RECEIVE_CATEGORIES = 'RECEIVE_CATEGORIES';

export function fetchCategoriesAction() {
  return function(dispatch) {
    return axios.get('http://localhost:5000/api/categories')
      .then(response => {
        dispatch({
          type: RECEIVE_CATEGORIES,
          data: response.data,
          receivedAt: Date.now()
        });
      })
  }
}