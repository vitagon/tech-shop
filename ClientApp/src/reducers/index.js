import { default as adminCategoriesReducer } from './admin/categoriesReducer';
import categoriesReducer from './categoriesReducer';
import navPanelReducer from './navPanelReducer';
import cartReducer from './cartReducer';
import {combineReducers} from 'redux';

export default combineReducers({
  adminCategoriesReducer,
  categoriesReducer,
  navPanelReducer,
  cartReducer
});