import { default as adminCategoriesReducer } from './admin/categoriesReducer';
import categoriesReducer from './categoriesReducer';
import navPanelReducer from './navPanelReducer';
import cartReducer from './cartReducer';
import breadcrumbsReducer from './breadcrumbsReducer';
import productsReducer from './productsReducer';
import {combineReducers} from 'redux';

export default combineReducers({
  adminCategoriesReducer,
  categoriesReducer,
  navPanelReducer,
  cartReducer,
  breadcrumbsReducer,
  productsReducer
});