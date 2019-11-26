import categoriesReducer from './categoriesReducer';
import navPanelReducer from './navPanelReducer';
import {combineReducers} from 'redux';

export default combineReducers({
  categoriesReducer,
  navPanelReducer
});