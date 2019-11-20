import axios from 'axios';
import { SHOW_DELETE_CATEGORY_MODAL, HIDE_DELETE_CATEGORY_MODAL, RECEIVE_CATEGORIES } from '../reducers/categoriesReducer';

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

export function createCategoryAction(obj) {
  return function (dispatch) {
    return axios.post('/api/categories', obj)
      .then(response =>
        dispatch(fetchCategoriesAction())
      )
      .catch(error => console.error(error));
  }
}

export function updateCategoryAction(obj) {
  return function (dispatch) {
    return axios.put(`/api/categories/${obj.id}`, obj)
      .then(response =>
        dispatch(fetchCategoriesAction())
      )
      .catch(error => console.error(error));
  }
}

export function deleteCategoryAction(id) {
  return function (dispatch) {
    dispatch(hideDeleteCategoryModal());
    return axios.delete(`/api/categories/${id}`)
      .then(response =>
        dispatch(fetchCategoriesAction())
      )
      .catch(error => console.error(error));
  }
}

export function hideDeleteCategoryModal() {
  return function (dispatch) {
    dispatch({ type: HIDE_DELETE_CATEGORY_MODAL });
  }
}

export function showDeleteCategoryModal(category) {
  return function (dispatch) {
    dispatch({
      type: SHOW_DELETE_CATEGORY_MODAL,
      data: category
    });
  }
}