import axios from 'axios';
import { RECEIVE_BREADCRUMBS_FOR_CATEGORY } from './../reducers/breadcrumbsReducer';

export function getBreadcrumbs(categoryUrl) { 
  return function (dispatch) {
    if (categoryUrl === null || categoryUrl === undefined) {
      categoryUrl = '';
    }
    axios.get(`/api/breadcrumbs/${categoryUrl}`)
      .then(response => {
        dispatch({
          type: RECEIVE_BREADCRUMBS_FOR_CATEGORY,
          data: response.data,
          receivedAt: Date.now()
        })
      })
  }
}