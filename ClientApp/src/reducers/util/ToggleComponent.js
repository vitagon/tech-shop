import _ from 'lodash';

export function toggleComponent(state, curObj, obj, componentVisibilityControlName, curObjControlName, closeAllComponents) {
  // show component when curObj is not set (curObj: {})
  if (_.isEmpty(curObj)) {
    return Object.assign({}, state, {
      [curObjControlName]: obj,
      [componentVisibilityControlName]: !state[componentVisibilityControlName]
    });
  }

  // show component in CASES:
  // 1. when component is opened but we want to UPDATE it's data (curObj)
  // 2. when component is closed but it's data was initialized before
  if (obj.id !== curObj.id) {
    closeAllComponents(state);
    return Object.assign({}, state, {
      [curObjControlName]: obj,
      [componentVisibilityControlName]: true
    });
  }
  // 1. when component is opened but we want to HIDE it
  // 2. when component is closed but we want to open it in case when initialized curObj == new obj
  else {
    if (!state[componentVisibilityControlName]) {
      closeAllComponents(state);
    }
    return Object.assign({}, state, {
      [curObjControlName]: obj,
      [componentVisibilityControlName]: !state[componentVisibilityControlName]
    });
  }
}